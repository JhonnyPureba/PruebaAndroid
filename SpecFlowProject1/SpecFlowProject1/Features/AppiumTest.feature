Feature: AppiumTest
Background: 
	Given El usuario se logea al app

@TC32
Scenario: Boton aplicar descuento y monto
	Given Selecciona opcion parking
	When el usuario selecciona imagen de voucher
	Then Verificar el monto y boton de descuento

#faltaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
@TC26
Scenario: Subir imagen incorrecta desde galeria
	Given Selecciona opcion parking
	When el usuario selecciona imagen Erronea de voucher

@TC2
Scenario: Verificar Modal al hacer clic en aplicar descuento
	Given Selecciona opcion parking
	When el usuario selecciona imagen de voucher
	When Selecciona opcion Aplicar un descuento
	Then Verificar modal con imagen 

@TC38
Scenario: Verificar al no seleccionar terminos y condiciones no se activar el boton pagar
	Given Selecciona opcion parking
	When el usuario selecciona imagen de voucher
	When Selecciona boton Pagar
	Then Visualiza boton Pagar deshabilitado

@TC8
Scenario: Verificar al  seleccionar terminos y condiciones se active el boton pagar
	Given Selecciona opcion parking
	When el usuario selecciona imagen de voucher
	When Selecciona boton Pagar
	When Marca checkbox de terminos y condiciones
	Then Visualiza boton Pagar habilitado

@TC5
Scenario: Aplicar descuento a voucher y verificar descuento aplicado
	Given Selecciona opcion parking
	When el usuario selecciona imagen de voucher
	When Selecciona opcion Aplicar un descuento
	And Selecciona boton Aplicar descuento
	Then Verificar que el descuento se aplique

	#DIVISION DE CASOS POR REALIZAR

@TC11
Scenario: Error al Aplicar descuento a voucher
	And Aplicar Codigo de Error "62"
	Given Selecciona opcion parking
	When el usuario selecciona imagen de voucher
	When Selecciona opcion Aplicar un descuento
	And Selecciona boton Aplicar descuento
	Then Verificar error de pantalla 

@TC14
Scenario: Desde pantalla de "no se aplico la promocion en aplicar descuento " muestra modal de establecimientos validos
	Given Selecciona opcion parking
	When el usuario selecciona imagen de voucher
	When Selecciona opcion Aplicar un descuento
	And Selecciona boton Aplicar descuento
	Then Verificar error de pantalla 

@TC17
Scenario: Error de servicio al aplicar descuento
	Given Selecciona opcion parking
	When el usuario selecciona imagen de voucher
	When Selecciona opcion Aplicar un descuento
	And Selecciona boton Aplicar descuento
	Then Verificar error de pantalla 

@TC20
Scenario: Pantalla de monto a pagar muestre mensaje de conoce los establecimientos validos aquí y al dar click muestre modal informativo
	Given Selecciona opcion parking
	When el usuario selecciona imagen de voucher
	When Selecciona opcion Aplicar un descuento
	And Selecciona boton Aplicar descuento
	Then Verificar error de pantalla 

@TC23
Scenario: Verificar un pago realizado con descuento se muestre en el historial de pagos
	Given Selecciona opcion parking
	When el usuario selecciona imagen de voucher
	When Selecciona opcion Aplicar un descuento
	And Selecciona boton Aplicar descuento
	Then Verificar error de pantalla 
