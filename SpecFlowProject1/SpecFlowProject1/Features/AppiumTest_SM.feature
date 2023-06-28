Feature: AppiumTest_SM

Escenarios de Pruebas para el flujo de Parking

Rule: Escenarios que validan los descuentos
Background: 
	Given El usuario ingresa al app
	Given Selecciona opcion parking 
	Given Selecciona opcion pago de estacionamiento 
	When Escanea qr 
	When Selecciona Modal aplicar descuento

@TC6
Scenario: Validar  que al dar clic en boton de aplicar descuento muestre mensaje de felicitaciones se aplico el descuento exitosamente
	When Selecciona opcion aplicar descuento
	Then Visualiza mensaje de felicitaciones

@TC9
Scenario: Validar que al dar clic en pagar descuento aplicado muestre pantalla de ingresar datos de la tarjeta y realiza pago exitoso
	When Selecciona opcion aplicar descuento
	When Selecciona link terminos y condiciones
	When Selecciona check terminos y condiciones
	When Selecciona opcion pagar
	When Completa datos de tarjeta 
	Then Visualiza titulo pantalla de pago exitoso
	
@TC12
Scenario: Validar mensaje de no se aplico la promocion en aplicar descuento pantalla de ingresar datos de la tarjeta y realiza pago exitoso
	When Selecciona opcion aplicar descuento
	When Selecciona link terminos y condiciones
	When Selecciona check terminos y condiciones
	When Selecciona opcion pagar
	Then Visualiza mensaje lo sentimos no se ha podido aplicar la promo

@TC15
Scenario: Validar mensaje  de Ups se agoto la promocion
	When Selecciona opcion aplicar descuento
	Then Visualiza mensaje de ups se agoto la promocion

@TC21
Scenario: Validar que el usuario pueda hacer uso de la promoción según la antidad configurada desde el cms 
	When Selecciona opcion aplicar descuento
	When Selecciona link terminos y condiciones
	When Selecciona check terminos y condiciones
	When Selecciona opcion pagar
	When Completa datos de tarjeta 
	Then Visualiza titulo pantalla de enchufe y transaccion

@TC33
Scenario: Validar  que al dar clic en aplicar descuento muestre un modal con imagen 
	Then Visualiza titulo el Modal de Aplicar Descuento
	
@TC36
Scenario: Validar  que al dar clic en botón de aplicar descuento muestre monto a pagar y monto que ahorraste en soles/porcentaje 
	When Selecciona opcion aplicar descuento
	Then Visualiza titulo pantalla de monto a pagar y monto ahorrado 

@TC39
Scenario:Validar que al marcar terminos y condiciones se active el boton de pagar  
	When Selecciona opcion aplicar descuento
	When Selecciona link terminos y condiciones
	When Selecciona check terminos y condiciones
	Then Visualiza titulo pantalla de datos de tarjeta
	

Rule: Escenarios que validan tickets validos y check de terminos y condiciones
Background: 
	Given El usuario ingresa al app
	Given Selecciona opcion parking 
	Given Selecciona opcion pago de estacionamiento 
	When Escanea qr 
	
@TC3
Scenario: Validar  que al dar clic terminos y condiciones muestre modal
	When Selecciona link terminos y condiciones
	Then Visualiza titulo el Modal de Terminos y condiciones

@TC18
Scenario: Validar que al dar clic en validar ticket de compra  muestre un modal de establecimientos validos 
	When Valida ticket de compra 
	Then Visualiza titulo modal de establecimientos validos


Rule: Escenarios que validan el historial de tickets
Background: 
	Given El usuario ingresa al app
	Given Selecciona opcion parking 
	Given Selecciona opcion pago de estacionamiento 
	When Selecciona opcion historial de pagos
	When Selecciona pago de cero soles
	
@TC24
Scenario: Validar Tickets
	Then Visualiza mensaje de validacion exitosa


Rule: Escenarios que validan el QR
Background: 
	Given El usuario ingresa al app
	Given Selecciona opcion parking 
	Given Selecciona opcion pago de estacionamiento 
	When Escanea qr 
	
@TC27
Scenario: Validar qr invalido
	Then Visualiza mensaje de qr invalido

