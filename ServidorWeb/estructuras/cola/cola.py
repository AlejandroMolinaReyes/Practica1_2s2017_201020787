from .nodo import Nodo

class Cola:

	def __init__(self):
		self.__primero = None
		self.__ultimo = None
		self.indice = 0

	def vacio(self):
		if self.__primero == None:
			return True
		else:
			return False

	def enqueue(self, dato):
		if self.vacio():
			self.__primero = self.__ultimo = Nodo(dato)
		else:
			nuevo = Nodo(dato)
			self.__ultimo.siguiente = nuevo
			self.__ultimo = nuevo
		self.indice = self.indice + 1


	def dequeue(self):
		if self.vacio():
			return None
		elif self.__primero==self.__ultimo:
			auxDato = self.__primero.dato
			self.__primero = self.__ultimo = None
			self.indice = self.indice - 1
			return auxDato
		else:
			auxDato = self.__primero.dato
			auxNodo = self.__primero.siguiente
			self.__primero.siguiente = None
			self.__primero = auxNodo
			self.indice = self.indice - 1
			return auxDato

	def mostrar(self):
		aux = self.__primero
		while aux!=None:
			yield aux
			aux = aux.siguiente


