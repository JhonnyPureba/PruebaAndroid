Feature: Parking_KO

Background: 
	Given El usuario se logea al app
	Given Selecciona opcion parking
	
@TC1
Scenario: Validar que al escanear un qr muetre pantalla del monto a pagar con la opcion de aplicar descuento
	When Selecciona opcion continuar 
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	Then Visualiza opcion Aplicar un descuento
	And Visualiza monto a pagar

#NO APLICA
@TC4
Scenario: Validar que al dar clic en aplicar descuento muestre un modal sin imagen
	When Selecciona opcion continuar 
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	When Selecciona opcion Aplicar un descuento
	Then Visualiza modal Aplicar un descuento

#TC7 version original, aplica descuento
#@TC7
#Scenario: Validar que si no se haya marcado terminos y condiciones no se active el boton de pagar, no permitiendo continuar el flujo
#	When Selecciona opcion continuar 
#	When Selecciona Subir codigo QR
#	When Escanea QR correcto
#	When Selecciona opcion Aplicar un descuento
#	Then Visualiza modal Aplicar un descuento
#	When Selecciona boton Aplicar descuento
#	Then Visualiza monto con descuento
#	And Visualiza checkbox de terminos y condiciones
#	And Visualiza boton Pagar deshabilitado

#TC7 version modificada, para validar en el caso que no haya descuentos
@TC7
Scenario: Validar que si no se haya marcado terminos y condiciones no se active el boton de pagar, no permitiendo continuar el flujo
	When Selecciona opcion continuar 
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	When Selecciona boton Pagar estacionamiento
	Then Visualiza checkbox de terminos y condiciones
	And Visualiza boton Pagar deshabilitado

#Verificar ultimos 2 steps
@TC10
Scenario: Validar que si se hizo el cobro del pago muestre pantalla de enchufe y numero de transaccion
	When Selecciona opcion continuar 
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	When Selecciona opcion Aplicar un descuento
	Then Visualiza modal Aplicar un descuento
	When Selecciona boton Aplicar descuento
	Then Visualiza monto con descuento
	And Visualiza checkbox de terminos y condiciones
	When Marca checkbox de terminos y condiciones
	Then Visualiza boton Pagar habilitado
	When Selecciona boton Pagar
	Then Visualiza modal Elige un medio de pago
	When Selecciona tarjeta como medio de pago
	Then Visualiza formulario Pago con tarjeta
	When Llena formulario con los datos de la tarjeta correcta
	And Selecciona monto a pagar
	Then Visualiza pantalla de enchufe y numero de transaccion

@TC13
Scenario: Validar que al dar clic en pagar estacionamiento desde pantalla de no se aplico la promocion en aplicar descuento muestra pantalla de monto a pagar
	When Selecciona opcion continuar 
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	When Selecciona opcion Aplicar un descuento
	Then Visualiza modal Aplicar un descuento
	When Selecciona boton Aplicar descuento
	Then Visualiza monto con descuento
	And Visualiza checkbox de terminos y condiciones
	When Marca checkbox de terminos y condiciones
	Then Visualiza boton Pagar habilitado
	When Selecciona boton Pagar
	Then Visualizar mensaje Lo sentimos, no se ha podido aplicar el descuento
	When Selecciona boton Pagar estacionamiento
	Then Visualiza monto a pagar

@TC16
Scenario: Validar error de conexi�n al aplicar descuento
	When Selecciona opcion continuar 
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	When Selecciona opcion Aplicar un descuento
	And Se pierde conexion
	Then Visualiza pantalla de error de conexion

@TC19
Scenario: Validar que al dar clic en bot�n continuar muestre pantalla de escanear qr o subir qr desde galeria
	When Selecciona opcion continuar 
	Then Visualiza Subir codigo QR

#@TC22
#Scenario: Validar el stock de descuentos seg�n configurado desde el cms
#	When Selecciona opcion Aplicar un descuento
#	Then Visualiza modal Aplicar un descuento
#	When Selecciona boton Aplicar descuento
#	Then Visualiza modal de descuento

########################################### TC28 No va aqui por el background
@TC28
Scenario: Validar escanear qr  desde ticket de compra
	When Selecciona opcion continuar 
	When Selecciona Subir codigo QR
	When Escanea QR incorrecto
	Then Visualiza mensaje UPS Error de imagen

########################################### TC31 que es dynamic link?
@TC31
Scenario: Validar pago exitoso aplicando descuento desde un dynamic link
	When Selecciona opcion continuar 
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	When Acceder al dynamic link
	Then Visualiza Parking

@TC34
Scenario: Validar que al dar clic terminos y condiciones muestre modal
	When Selecciona opcion continuar 
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	When Selecciona opcion Aplicar un descuento
	Then Visualiza modal Aplicar un descuento
	When Selecciona link Conoce los terminos y condiciones
	Then Visualiza modal Terminos y Condiciones

@TC37
Scenario: Validar que al dar clic en bot�n de aplicar descuento muestre mensaje de "felicitaciones, se aplic� el descuento exitosamente"
	When Selecciona opcion continuar 
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	When Selecciona opcion Aplicar un descuento
	Then Visualiza modal Aplicar un descuento
	When Selecciona boton Aplicar descuento
	Then Visualiza mensaje Felicitaciones se aplico el descuento exitosamente

@TC40
Scenario: Validar que al dar clic en pagar descuento aplicado muestre pantalla de ingresar datos de la tarjeta y realiza pago exitoso 
	When Selecciona opcion continuar 
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	When Selecciona opcion Aplicar un descuento
	Then Visualiza modal Aplicar un descuento
	When Selecciona boton Aplicar descuento
	Then Visualiza monto con descuento
	And Visualiza checkbox de terminos y condiciones
	When Marca checkbox de terminos y condiciones
	When Selecciona boton Pagar
	Then Visualiza modal Elige un medio de pago
	When Selecciona tarjeta como medio de pago
	Then Visualiza formulario Pago con tarjeta
	When Llena formulario con los datos de la tarjeta correcta
	And Selecciona monto a pagar
	Then Visualiza pantalla Pago exitoso