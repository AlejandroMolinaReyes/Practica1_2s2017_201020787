from estructuras import ListaSimple , ListaDoble
from flask import Flask, request
from usuario import Usuario
from leerXML import cargaXML
from leerJSON import cargaJSON

servidor = Flask(__name__)

@servidor.route('/prueba',methods=['POST']) 
def prueba():
    param = str(request.form['param'])
    return param

if __name__ == "__main__":
	servidor.run(debug=True, host='127.0.0.1')