Feature: AppiumTest
Background: 
	Given El usuario se logea al app

@mytag
Scenario: Boton aplicar descuento y monto
	Given Selecciona opcion parking
	When el usuario selecciona imagen de voucher
	Then Verificar el monto y boton de descuento

#faltaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
@mytag
Scenario: Subir imagen incorrecta desde galeria
	Given Selecciona opcion parking
	When el usuario selecciona imagen Erronea de voucher


Scenario: Verificar Modal al hacer clic en aplicar descuento
	Given Selecciona opcion parking
	When el usuario selecciona imagen de voucher
	And seleccionar aplicar descuento 
	Then Verificar modal con imagen 

Scenario: Verificar al no seleccionar terminos y condiciones no se activar el boton pagar
	Given Selecciona opcion parking
	When el usuario selecciona imagen de voucher
	When el usuario selecciona boton pagar
	Then Verificar que el boton de pagar este deshabilitado

Scenario: Verificar al  seleccionar terminos y condiciones se active el boton pagar
	Given Selecciona opcion parking
	When el usuario selecciona imagen de voucher
	When el usuario selecciona boton pagar
	And el usuario aceptar terminos y condiciones 
	Then Verificar que el boton de pagar este habilitado

Scenario: Aplicar descuento a voucher
	Given Selecciona opcion parking
	When el usuario selecciona imagen de voucher
	When el usuario selecciona aplicar un descuento 
	And el usuario selecciona aplicar descuento
	Then Verificar que el descuento se aplique

Scenario: Error al Aplicar descuento a voucher
	And Aplicar Codigo de Error "62"
	Given Selecciona opcion parking
	When el usuario selecciona imagen de voucher
	When el usuario selecciona aplicar un descuento 
	And el usuario selecciona aplicar descuento
	Then Verificar error de pantalla 

Scenario: Desde pantalla de "no se aplico la promocion en aplicar descuento " muestra modal de establecimientos validos
	Given Selecciona opcion parking
	When el usuario selecciona imagen de voucher
	When el usuario selecciona aplicar un descuento 
	And el usuario selecciona aplicar descuento
	Then Verificar error de pantalla 

Scenario: Error de servicio al aplicar descuento
	Given Selecciona opcion parking
	When el usuario selecciona imagen de voucher
	When el usuario selecciona aplicar un descuento 
	And el usuario selecciona aplicar descuento
	Then Verificar error de pantalla 

Scenario: Pantalla de monto a pagar muestre mensaje de conoce los establecimientos validos aquí y al dar click muestre modal informativo
	Given Selecciona opcion parking
	When el usuario selecciona imagen de voucher
	When el usuario selecciona aplicar un descuento 
	And el usuario selecciona aplicar descuento
	Then Verificar error de pantalla 

Scenario: Verificar un pago realizado con descuento se muestre en el historial de pagos
	Given Selecciona opcion parking
	When el usuario selecciona imagen de voucher
	When el usuario selecciona aplicar un descuento 
	And el usuario selecciona aplicar descuento
	Then Verificar error de pantalla 
