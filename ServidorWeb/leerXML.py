from xml.etree import ElementTree 
import os 
"""
con findall extraigo etiquetas repetidas y con for leo su valor
con find extraigo la etiqueta que no se repiten y con for leo su valor
"""
def cargaXML(path):
	try:
		full_file = os.path.abspath(os.path.join(path))
		raiz = ElementTree.parse(full_file)
		mensaje = raiz.findall('mensaje')# etiquetas repetidas
		for msj  in mensaje:
			texto = msj.find('texto').text # una sola etiqueta
			IP = msj.findall('nodos/IP')# etiquetas repetidas
			for ip  in IP:
				yield ip.text.strip(),texto.strip()
			IP = msj.findall('IP')# tiquetas repetidas
			for ip  in IP:
				yield ip.text.strip(),texto.strip()		
	except Exception as error:
		print("Error en la carga del XML")
		yield False,False

#for ip,texto in cargaXML("carga.xml"):
	#print(ip,texto)


