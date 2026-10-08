Algoritmo AdivinaElNumero
		Definir secreto, intencion, intentos Como Entero
		Definir acertado Como Logico
		
		// La computadora elige un número secreto al azar entre 1 y 50
		secreto <- azar(100) + 1
		
		intentos <- 0
		acertado <- Falso
		
		// Ciclo Repetir para los intentos
		Repetir
			intentos <- intentos + 1
			Escribir "> " Sin Saltar
			Leer intencion
			
			// Un SI dentro de otro para validar si es alto, bajo o correcto
			Si intencion = secreto Entonces
				acertado <- Verdadero
			Sino
				Si intencion < secreto Entonces
					Escribir "Mas alto"
				Sino
					Escribir "Mas bajo"
				FinSi
			FinSi
			
			// Termina cuando acierta o cuando gasta los cinco intentos
			// Usando el operador lógico O
		Hasta Que acertado = Verdadero O intentos = 10
		
		// Mensaje final según el resultado
		Si acertado Entonces
			Escribir "Correcto en ", intentos, " intentos"
		Sino
			Escribir "Perdiste. El número secreto era: ", secreto
		FinSi
FinAlgoritmo
Algoritmo AdivinaElNumero
		Definir secreto, intencion, intentos Como Entero
		Definir acertado Como Logico
		
		// La computadora elige un número secreto al azar entre 1 y 50
		secreto <- azar(100) + 1
		
		intentos <- 0
		acertado <- Falso
		
		// Ciclo Repetir para los intentos
		Repetir
			intentos <- intentos + 1
			Escribir "> " Sin Saltar
			Leer intencion
			
			// Un SI dentro de otro para validar si es alto, bajo o correcto
			Si intencion = secreto Entonces
				acertado <- Verdadero
			Sino
				Si intencion < secreto Entonces
					Escribir "Mas alto"
				Sino
					Escribir "Mas bajo"
				FinSi
			FinSi
			
			// Termina cuando acierta o cuando gasta los cinco intentos
			// Usando el operador lógico O
		Hasta Que acertado = Verdadero O intentos = 10
		
		// Mensaje final según el resultado
		Si acertado Entonces
			Escribir "Correcto en ", intentos, " intentos"
		Sino
			Escribir "Perdiste. El número secreto era: ", secreto
		FinSi
FinAlgoritmo
