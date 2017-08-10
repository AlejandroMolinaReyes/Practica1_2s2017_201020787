from .nodo import Nodo


class ListaDoble:

	def __init__(self):
		self.__primero = None
		self.__ultimo = None

	def vacio(self):
		if self.__primero == None:
			return True
		else:
			return False


	def agregar_final(self, dato):
		if self.vacio():
			self.__primero = self.__ultimo = Nodo(dato)
		else:
			nuevo = Nodo(dato)
			self.__ultimo.siguiente = nuevo
			nuevo.anterior = self.__ultimo
			self.__ultimo = nuevo

	def recorrer_inicio_fin(self):
		aux = self.__primero
		while aux:
			print(aux.dato)
			aux = aux.siguiente
		
	def recorrer_fin_inicio(self):
		aux = self.__ultimo
		while aux:
			print(aux.dato)
			aux = aux.anterior

	def buscar(self, nombre):
		aux = self.__primero
		if self.__primero!=None:
			while aux:
				if aux.dato == nombre:
					return aux.dato
				aux = aux.siguiente