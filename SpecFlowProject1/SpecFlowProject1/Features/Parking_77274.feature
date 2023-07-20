Feature: Parking_77274

Background: 
	Given El usuario se logea al app

@TC9
Scenario: Visualizar mensaje error de red en scanner
	Given Selecciona opcion parking	
	When Se pierde conexion scanner
	Given Selecciona opcion continuar 
	When el usuario selecciona imagen de voucher
	Then Visualiza pantalla de error de conexion scanner

@TC12
Scenario: Visualizar mensaje de error de red en Ticket de compra
	Given Selecciona opcion parking
	And Selecciona opcion continuar
	When el usuario selecciona imagen de voucher
	When Selecciona opcion Validar ticket de compra
	And Seleccionar continuar en Ticket de compra
	And Se pierde conexion Ticket Compra
	When el usuario selecciona imagen de ticket de compra
	Then Visualiza pantalla de error de conexion scanner

@TC10
Scenario: Visualizar mensaje de error de servicio en scanner
	And Aplicar Codigo de Error "1"
	Given Selecciona opcion parking directo
	And Selecciona opcion continuar
	When el usuario selecciona imagen de voucher
	Then Visualiza pantalla de error de servicio scanner

@TC13
Scenario: Validar mensaje de error de servicios ticket de compra
	And Aplicar Codigo de Error "4"
	Given Selecciona opcion parking directo
	And Selecciona opcion continuar
	When el usuario selecciona imagen de voucher
	When Selecciona opcion Validar ticket de compra
	And Seleccionar continuar en Ticket de compra
	When el usuario selecciona imagen de ticket de compra
	Then Visualiza pantalla de error de servicio scanner

@TC14
Scenario: Validar mensaje de error ticket de compra no valido
	And Aplicar Codigo de Error "10"
	Given Selecciona opcion parking directo
	And Selecciona opcion continuar
	When el usuario selecciona imagen de voucher
	When Selecciona opcion Validar ticket de compra
	And Seleccionar continuar en Ticket de compra
	When el usuario selecciona imagen error de ticket de compra
	Then Visualizar mensaje de error no valido para ticket de compra

@TC15
	Scenario: Visualizar mensaje error no se aplico la promocion al aplicar descuento
	And Aplicar Codigo de Error "62"
	Given Selecciona opcion parking directo
	And Selecciona opcion continuar
	When el usuario selecciona imagen de voucher
	When Selecciona opcion Aplicar un descuento
	And Selecciona boton Aplicar descuento
	Then Verificar error de pantalla no aplico descuento


#CASOS PENDIENTES 

@TC17
Scenario: Visualizar mensaje de error de servicio al seleccionar pagar 
	And Aplicar Codigo de Error "7"
	Given Selecciona opcion parking directo
	And Selecciona opcion continuar
	When el usuario selecciona imagen de voucher
	When Selecciona opcion Aplicar un descuento
	And Selecciona boton Aplicar descuento
	When Marca checkbox de terminos y condiciones
	When Selecciona boton Pagar
	And Seleccionar continuar 
	Then Visualizar mensaje error de servicios en pago

