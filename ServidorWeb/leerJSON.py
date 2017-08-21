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
			yield "201020787",nodos['local'],nodos['mascara']
			for nodo in nodos['nodo']:
				yield "",nodo['ip'],nodo['mascara']
	except Exception as error:
		print("error en la carga JSON")
		yield False,False,False

#for usuario,ip,mascara in cargaJSON('C:\ServidorWeb\cargaJSON.json'):
	#print(usuario,ip,mascara)
