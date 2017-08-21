# -*- coding: utf-8 -*-
#!/usr/bin/env python
from estructuras import ListaSimple , ListaDoble , Cola
from flask import Flask, request
from nodo import Nodo
from leerXML import cargaXML
from leerJSON import cargaJSON
from mensaje import Mensaje
from respuesta import Respuesta

listaNodos = ListaSimple()
listaRespuesta = ListaDoble()
colaMensajes = Cola()

servidor = Flask(__name__)
# get request.args.get('path')
# post path = request.form['path']
@servidor.route('/cargaJSON',methods=['POST']) 
def abrirJON():
	path = request.form['path']
	global  listaNodos
	for carnet,ip,mascara in cargaJSON(path):
		if carnet == False and ip == False and mascara == False:
			return "False"
		else:
			validar = listaNodos.buscarIP(ip)
			if validar == None:
				listaNodos.agregar(Nodo(carnet,ip,mascara))
	return "True"

@servidor.route('/dashboard',methods=['POST']) 
def dashboard():
	global listaNodos
	return listaNodos.recorrer()

@servidor.route('/ip',methods=['POST']) 
def ip():
	carnet = request.form['carnet']
	global listaNodos
	ip = listaNodos.buscarCarnet(carnet)
	if ip == None:
		return "False"
	else:
		resultado = ip.ip+","+ip.mascara
		return resultado

@servidor.route('/updateCarnet',methods=['POST']) 
def updateCarnet():
	ip = request.form['ip']
	carnet = request.form['carnet']
	global  listaNodos
	nodoCarnet = listaNodos.buscarIP(ip)
	if nodoCarnet == None:
		return "False"
	else:
		nodoCarnet.carnet = carnet
		return "True"

@servidor.route('/cargaXML',methods=['POST']) 
def abrirXML():
	path = request.form['path']
	resultado  = ""
	for ip,msj in cargaXML(path):
		if ip == False and  msj == False:
			return "False"
		else:
			resultado = resultado + str(ip)+","+str(msj)+";"
	return resultado

@servidor.route('/graficarCola',methods=['POST']) 
def graficarCola():
	resultado = "digraph cola {\n"
	indice = 1
	global colaMensajes
	for elemento in colaMensajes.mostrar():
		if elemento.siguiente != None and elemento!=None:
			resultado = resultado + "\t\"Operacion"+str(indice)+":"+elemento.dato.ip + "," + elemento.dato.mensaje + "\"-> \"Operacion"+str(indice+1)+":"+ elemento.siguiente.dato.ip+","+elemento.siguiente.dato.mensaje+"\";\n"
			indice = indice + 1
		elif elemento!=None and elemento.siguiente == None:
			resultado = resultado + "\t\"Operacion"+str(indice)+":"+elemento.dato.ip + "," + elemento.dato.mensaje + "\""
	resultado = resultado + "\n}"
	return resultado

@servidor.route('/operar',methods=['POST']) 
def operar():
	global  colaMensajes
	msj= colaMensajes.dequeue()
	if msj == None:
		return "vacio"
	else:
		result = msj.postorden()
		if result == "false":
			return "FalseP"
		else:
			result = msj.operar()
			if result == "false":
				return "FalseO"
			else:
				indice = str(colaMensajes.indice)
				carnet = msj.carnet
				ip = msj.ip
				resultado = str(msj.resultado)
				inorden = msj.mensaje
				postorden = msj.post
				pasos = msj.pasos
				return indice+","+carnet+","+ip+","+resultado+","+inorden+","+postorden+";"+pasos
				

@servidor.route('/reciente',methods=['GET']) 
def reciente():
	global listaRespuesta
	resultado = ""
	for dato in listaRespuesta.recorrer_inicio_fin():
		resultado = resultado + dato.carnet+","+dato.ip+","+dato.inorden+","+dato.post+","+dato.resultado+";"
	return resultado

@servidor.route('/antiguos',methods=['GET']) 
def antiguos():
	global listaRespuesta
	resultado = ""
	for dato in listaRespuesta.recorrer_fin_inicio():
		resultado = resultado + dato.carnet+","+dato.ip+","+dato.inorden+","+dato.post+","+dato.resultado+";"
	return resultado


@servidor.route('/conectado',methods=['GET']) 
def conectado():
	return "201020787"


@servidor.route('/mensaje',methods=['POST']) 
def mensaje():
	msj = request.form['inorden']
	print(msj)
	ip = request.remote_addr
	global colaMensajes
	global listaNodos
	carnet = listaNodos.buscarIP(ip)
	if carnet == None:
		return "false"
	else:
		colaMensajes.enqueue(Mensaje(carnet.carnet,ip,msj))
		return "true"

@servidor.route('/respuesta',methods=['POST']) 
def respuesta():
	inorden = request.form['inorden']
	postorden  = request.form['postorden']
	resultado = request.form['resultado']
	ip = request.remote_addr
	global listaNodos
	carnet = listaNodos.buscarIP(ip)
	if carnet == None:
		return "false"
	else:
		global listaRespuesta
		listaRespuesta.agregar(Respuesta(carnet.carnet,ip,inorden,postorden,resultado))
		return "true"


if __name__ == "__main__":
	servidor.run(debug=True, host='0.0.0.0')