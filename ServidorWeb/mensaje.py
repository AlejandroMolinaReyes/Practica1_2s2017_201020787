from estructuras import Pila

class Mensaje:

	def __init__(self,carnet,ip,mensaje):
		self.carnet = carnet
		self.ip = ip
		self.mensaje = mensaje
		self.post = ""
		self.resultado = ""
		self.pasos = ""

	def postorden(self):
		numero = Pila()
		signo = Pila()
		num = ""
		result = ""
		if self.mensaje == "":
			return "false"
		for caracter  in self.mensaje:
			if caracter == "(" or caracter == " " or caracter=="\t" or caracter == "\n" or caracter =="": 
				pass
			elif caracter>="0" and caracter<="9":
				num = num + caracter
			elif caracter == "+" or caracter == "-" or caracter == "*" or caracter == "/":
				if num != "":
					numero.push(num)
					num = ""
				signo.push(caracter)
			elif caracter==")":
				if num != "":
					numero.push(num)
					num = ""
				valSigno = signo.pop()
				if valSigno != None:
					numero.push(valSigno)
				else:
					return "false"
		if signo.vacio() == False:
			return "false"
		for cadena in numero.mostrar():
			if cadena != None:
				result = cadena + " " + result
				self.post = result.strip()
		return "true"

	def operar(self):
		operacion = self.post
		aux = ""
		self.pasos = ""
		pila = Pila()
		if operacion!=None:
			for caracter in operacion:
				#------------------------------------contatedo numero
				if caracter>='0' and caracter<='9':
					aux = aux + caracter
				#-------------------------------apilar numero
				elif caracter == " ":
					if aux!="":
						self.pasos = self.pasos + "push(" + aux + "),"
						pila.push(int(aux))
					aux = ""
				#-------------------------------- sumo numeros
				elif caracter =="+":
					numero2 = pila.pop()
					numero1 = pila.pop()
					self.pasos = self.pasos + "pop(),pop(),"
					if numero1!=None and numero2!=None:
						resultado = numero1 + numero2
						self.pasos = self.pasos + str(numero1)+ " + " + str(numero2) + " = " + str(resultado) + ","
						pila.push(resultado)
						self.pasos = self.pasos + "push(" + str(resultado) + "),"
					else:
						self.pasos = self.pasos + "Error de syntaxis :("
						return "false"
				#-------------------- resto numeros
				elif caracter == "-":
					numero2 = pila.pop()
					numero1 = pila.pop()
					if numero1!=None and numero2!=None:
						resultado = numero1 - numero2
						self.pasos = self.pasos + str(numero1)+ " - " + str(numero2) + " = " + str(resultado) + ","
						pila.push(resultado)
						self.pasos = self.pasos + "push(" + str(resultado) + "),"
					else:
						self.pasos = self.pasos + "Error de syntaxis :("
						return "false"
				#---------------------------- multiplico numeros
				elif caracter=="*":
					numero2 = pila.pop()
					numero1 = pila.pop()
					self.pasos = self.pasos + "pop(),pop(),"
					if numero1!=None and numero2!=None:
						resultado = numero1 * numero2
						self.pasos = self.pasos + str(numero1)+ " + " + str(numero2) + " = " + str(resultado) + ","
						pila.push(resultado)
						self.pasos = self.pasos + "push(" + str(resultado) + "),"
					else:
						self.pasos = self.pasos + "Error de syntaxis :("
						return "false"
				#---------------------------- multiplico numeros
				elif caracter=="/":
					numero2 = pila.pop()
					numero1 = pila.pop()
					self.pasos = self.pasos + "pop(),pop(),"
					if numero1!=None and numero2!=None:
						resultado = numero1 / numero2
						self.pasos = self.pasos + str(numero1)+ " / " + str(numero2) + " = " + str(resultado) + ","
						pila.push(resultado)
						self.pasos = self.pasos + "push(" + str(resultado) + "),"
					else:
						self.pasos = self.pasos + "Error de syntaxis :("
						return "false"
				#------------------------------ cacater raro
				elif caracter=="\t" or caracter == "\n":
					pass
				else:
					pass
			self.resultado = pila.pop()
			if pila.vacio() == False:
				self.pasos = self.pasos + "Error de syntaxis :("
				return "false"
			else:
				self.pasos = self.pasos + "Resultado = " + str(resultado)
				return "true"
				#print("Respuesta:",self.resultado)			
		else:
			self.pasos = self.pasos + "Error de syntaxis :("
			return "false"










