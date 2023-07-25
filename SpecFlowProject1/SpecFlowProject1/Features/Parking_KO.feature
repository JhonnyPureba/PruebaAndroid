Feature: Parking_KO
	
@TC01
Scenario: TC01-Validar que al escanear un qr muetre pantalla del monto a pagar con la opcion de aplicar descuento
	Given El usuario se logea al app
	Given Selecciona opcion parking
	When Selecciona boton Continuar
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	Then Visualiza opcion Aplicar un descuento
	And Visualiza monto a pagar

@TC07
Scenario: TC07-Validar que si no se haya marcado terminos y condiciones no se active el boton de pagar, no permitiendo continuar el flujo
	Given El usuario se logea al app
	Given Selecciona opcion parking
	When Selecciona boton Continuar
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	When Selecciona opcion Aplicar un descuento
	Then Visualiza modal Aplicar un descuento
	When Selecciona boton Aplicar descuento
	Then Visualiza monto con descuento
	And Visualiza checkbox de terminos y condiciones
	And Visualiza boton Pagar deshabilitado

@TC10
Scenario: TC10-Validar que si se hizo el cobro del pago muestre pantalla de enchufe y numero de transaccion
	Given El usuario se logea al app
	And Aplicar Codigo de Error "7"
	And Selecciona opcion parking directo
	When Selecciona boton Continuar 
	When Selecciona Subir codigo QR
	When Escanea QR correcto 2
	When Selecciona boton Pagar estacionamiento
	Then Visualiza checkbox de terminos y condiciones
	When Marca checkbox de terminos y condiciones
	When Selecciona boton Pagar
	Then Visualiza modal Importante
	When Selecciona boton Continuar
	Then Visualiza modal Elige un medio de pago
	When Selecciona tarjeta como medio de pago
	Then Visualiza formulario Pago con tarjeta
	When Llena formulario con los datos de la tarjeta con fondos
	And Selecciona monto a pagar
	Then Visualiza pantalla de enchufe y numero de transaccion

@TC13
Scenario: TC13-Validar que al dar clic en pagar estacionamiento desde pantalla de no se aplico la promocion en aplicar descuento muestra pantalla de monto a pagar
	Given El usuario se logea al app
	And Aplicar Codigo de Error "62"
	Given Selecciona opcion parking directo
	When Selecciona boton Continuar 
	When Selecciona Subir codigo QR
	When Escanea QR correcto 2
	When Selecciona opcion Aplicar un descuento
	And Selecciona boton Aplicar descuento
	Then Verificar error de pantalla no aplico descuento

@TC16
Scenario: TC16- error de conexión al aplicar descuento
	Given El usuario se logea al app
	Given Selecciona opcion parking
	When Selecciona boton Continuar
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	When Selecciona opcion Aplicar un descuento
	And Se pierde conexion
	And Selecciona boton Aplicar descuento
	Then Visualiza pantalla de error de conexion

@TC19
Scenario: TC19-Validar que al dar clic en botón continuar muestre pantalla de escanear qr o subir qr desde galeria
	Given El usuario se logea al app
	Given Selecciona opcion parking
	When Selecciona boton Continuar
	Then Visualiza Subir codigo QR

@TC27
Scenario: TC27-Validar escanear qr  desde ticket de compra
	Given El usuario se logea al app
	Given Selecciona opcion parking
	When Selecciona boton Continuar
	When Selecciona Subir codigo QR
	When Escanea QR incorrecto
	Then Visualiza mensaje UPS Error de imagen

@TC33
Scenario: TC33-Verificar al dar clic en aplicar descuento muestre un modal con imagen
	Given El usuario se logea al app
	Given Selecciona opcion parking
	When Selecciona boton Continuar
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	When Selecciona opcion Aplicar un descuento
	Then Visualiza modal Aplicar un descuento

@TC34
Scenario: TC34-Validar que al dar clic terminos y condiciones muestre modal
	Given El usuario se logea al app
	Given Selecciona opcion parking
	When Selecciona boton Continuar
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	When Selecciona opcion Aplicar un descuento
	Then Visualiza modal Aplicar un descuento
	When Selecciona link Conoce los terminos y condiciones
	Then Visualiza modal Terminos y Condiciones

@TC36
Scenario: TC36-Verificar al dar clic en boton de aplicar descuento muestre monto a pagar y monto que ahorraste
	Given El usuario se logea al app
	Given Selecciona opcion parking
	When Selecciona boton Continuar
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	When Selecciona opcion Aplicar un descuento
	Then Visualiza modal Aplicar un descuento
	When Selecciona boton Aplicar descuento
	Then Visualiza mensaje Ahorraste en tu pago de estacionamiento

@TC37
Scenario: TC37-Validar que al dar clic en botón de aplicar descuento muestre mensaje de "felicitaciones, se aplicó el descuento exitosamente"
	Given El usuario se logea al app
	Given Selecciona opcion parking
	When Selecciona boton Continuar
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	When Selecciona opcion Aplicar un descuento
	Then Visualiza modal Aplicar un descuento
	When Selecciona boton Aplicar descuento
	Then Visualiza mensaje Felicitaciones se aplico el descuento exitosamente

@TC39
Scenario: TC39-Verificar que al marcar terminos y condiciones se active el boton de pagar
	Given El usuario se logea al app
	Given Selecciona opcion parking
	When Selecciona boton Continuar
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	When Selecciona opcion Aplicar un descuento
	Then Visualiza modal Aplicar un descuento
	When Selecciona boton Aplicar descuento
	Then Visualiza monto con descuento
	And Visualiza checkbox de terminos y condiciones
	When Marca checkbox de terminos y condiciones
	Then Visualiza boton Pagar habilitado

@TC40
Scenario: TC40-Validar que al dar clic en pagar descuento aplicado muestre pantalla de ingresar datos de la tarjeta y realiza pago exitoso
	Given El usuario se logea al app
	Given Selecciona opcion parking
	When Selecciona boton Continuar
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	When Selecciona opcion Aplicar un descuento
	Then Visualiza modal Aplicar un descuento
	When Selecciona boton Aplicar descuento
	Then Visualiza monto con descuento
	And Visualiza checkbox de terminos y condiciones
	When Marca checkbox de terminos y condiciones
	When Selecciona boton Pagar
	Then Visualiza modal Importante
	When Selecciona boton Continuar
	Then Visualiza modal Elige un medio de pago
	When Selecciona tarjeta como medio de pago
	Then Visualiza formulario Pago con tarjeta
	When Llena formulario con los datos de la tarjeta con fondos
	And Selecciona monto a pagar
	Then Visualiza pantalla Pago exitoso