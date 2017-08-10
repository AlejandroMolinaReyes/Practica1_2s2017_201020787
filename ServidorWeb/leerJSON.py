import json
import os 
"""
la libreria json abre el archivo y convierte el json en diccionarios
Los leo con for y incresando a cada uno
"""
def cargaJSON(path):
	try:
		full_file = os.path.abspath(os.path.join(path))
		leer = json.loads(open(full_file).read()).values()
		for nodos in leer:
			yield 'admin',nodos['local'],nodos['mascara']
			for nodo in nodos['nodo']:
				yield nodo['carnet'],nodo['ip'],nodo['mascara']
	except Exception as error:
		yield False,False,False

#for usuario,ip,mascara in cargaJSON('C:\Practica1EDD\cargaJSON.json'):
	#print(usuario,ip,mascara)
