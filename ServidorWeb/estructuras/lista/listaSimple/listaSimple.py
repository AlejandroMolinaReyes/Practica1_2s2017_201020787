from .nodo import Nodo


class ListaSimple:

	def __init__(self):
		self.__primero = None
		self.__ultimo = None

	def vacio(self):
		if self.__primero == None:
			return True
		else:
			return False


	def agregar(self, dato):
		if self.vacio():
			self.__primero = self.__ultimo = Nodo(dato)
		else:
			nuevo = Nodo(dato)
			self.__ultimo.siguiente = nuevo
			self.__ultimo = nuevo

	def recorrer(self):
		aux = self.__primero
		lista = ""
		while aux:
			lista = lista+aux.dato.carnet+","+aux.dato.ip+","+aux.dato.mascara+";"
			aux = aux.siguiente
		return lista
		

	def buscarIP(self, ip):
		aux = self.__primero
		if self.__primero!=None:
			while aux:
				if aux.dato.ip == ip:
					return aux.dato
				aux = aux.siguiente

	def buscarCarnet(self, carnet):
		aux = self.__primero
		if self.__primero!=None:
			while aux:
				if aux.dato.carnet == carnet:
					return aux.dato
				aux = aux.siguiente

