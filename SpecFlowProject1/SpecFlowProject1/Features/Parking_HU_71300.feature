Feature: HU 71300 Promociones y descuentos Parking
Background: 
	Given El usuario se logea al app
	
@TC01
Scenario: TC01-Validar que al escanear un qr muetre pantalla del monto a pagar con la opcion de aplicar descuento
	Given Selecciona opcion parking
	When Selecciona boton Continuar
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	Then Visualiza opcion Aplicar un descuento
	And Visualiza monto a pagar

@TC2
Scenario: TC02-Verificar Modal al hacer clic en aplicar descuento
	Given Selecciona opcion parking
	When Selecciona boton Continuar
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	When Selecciona opcion Aplicar un descuento
	Then Verificar modal con imagen 

@TC3
Scenario: TC03-Verificar al dar clic en terminos y condiciones muestre modal
	Given Selecciona opcion parking
	When Selecciona boton Continuar 
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	When Selecciona opcion Aplicar un descuento
	When Selecciona link terminos y condiciones
	Then Visualiza titulo de terminos y condiciones 

@TC5
Scenario: TC05-Aplicar descuento a voucher y verificar descuento aplicado
	Given Selecciona opcion parking
	When Selecciona boton Continuar
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	When Selecciona opcion Aplicar un descuento
	And Selecciona boton Aplicar descuento
	Then Verificar que el descuento se aplique

@TC6
Scenario: TC06-Visualizar al aplicar descuento muestre mensaje "felicitaciones, se aplico el descuento exitosamente"
	Given Selecciona opcion parking
	When Selecciona boton Continuar 
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	When Selecciona opcion Aplicar un descuento
	And Selecciona boton Aplicar descuento
	Then Visualizar el mensaje exitoso cuando el descuento se aplique

@TC07
Scenario: TC07-Validar que si no se haya marcado terminos y condiciones no se active el boton de pagar, no permitiendo continuar el flujo
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

@TC8
Scenario: TC08-Verificar al  seleccionar terminos y condiciones se active el boton pagar
	Given Selecciona opcion parking
	When Selecciona boton Continuar
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	And Selecciona boton Pagar estacionamiento
	When Marca checkbox de terminos y condiciones
	Then Visualiza boton Pagar habilitado

@TC9
Scenario: TC09-Pago exitoso y muestre datos correctos 
	Given Selecciona opcion parking
	When Selecciona boton Continuar
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	When Selecciona opcion Aplicar un descuento
	And Selecciona boton Aplicar descuento
	When Marca checkbox de terminos y condiciones
	When Selecciona boton Pagar
	And Seleccionar continuar 
	And Seleccionar metodo de pago tarjeta credito debito
	And Seleccionar boton continuar dentro de pago
	When Ingresar datos de tarjeta correctos
	Then Visualizar pago exitoso en voucher

@TC10
Scenario: TC10-Validar que si se hizo el cobro del pago muestre pantalla de enchufe y numero de transaccion
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

@TC11
Scenario: TC11-Validar que al hacer clic en el boton pagar  muestre la pantalla de error de servicios
	And Aplicar Codigo de Error "7"
	Given Selecciona opcion parking directo
	When Selecciona boton Continuar 
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	When Selecciona opcion Aplicar un descuento
	And Selecciona boton Aplicar descuento
	When Marca checkbox de terminos y condiciones
	When Selecciona boton Pagar
	And Seleccionar continuar 
	Then Visualizar mensaje error de servicios en pago

@TC12
	Scenario: TC12-Visualizar mensaje error no se aplico la promocion al aplicar descuento
	And Aplicar Codigo de Error "62"
	Given Selecciona opcion parking directo
	When Selecciona boton Continuar 
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	When Selecciona opcion Aplicar un descuento
	And Selecciona boton Aplicar descuento
	Then Verificar error de pantalla no aplico descuento

@TC13
Scenario: TC13-Validar que al dar clic en pagar estacionamiento desde pantalla de no se aplico la promocion en aplicar descuento muestra pantalla de monto a pagar
	And Aplicar Codigo de Error "62"
	Given Selecciona opcion parking directo
	When Selecciona boton Continuar 
	When Selecciona Subir codigo QR
	When Escanea QR correcto 2
	When Selecciona opcion Aplicar un descuento
	And Selecciona boton Aplicar descuento
	Then Verificar error de pantalla no aplico descuento

@TC14
Scenario: TC14-Validar modal informativo de establecimientos validos en ticket de compra
	And Selecciona opcion parking
	When Selecciona boton Continuar 
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	Then Visualiza opcion Validar ticket de compra
	When Selecciona opcion Validar ticket de compra
	Then Visualiza modal Establecimientos validos

@TC16
Scenario: TC16-Error de conexión al aplicar descuento
	Given Selecciona opcion parking
	When Selecciona boton Continuar
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	When Selecciona opcion Aplicar un descuento
	And Se pierde conexion
	And Selecciona boton Aplicar descuento
	Then Visualiza pantalla de error de conexion

@TC17
	Scenario: TC17-Error de servicios al aplicar descuento 
	And Aplicar Codigo de Error "4"
	Given Selecciona opcion parking directo
	When Selecciona boton Continuar
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	When Selecciona opcion Aplicar un descuento
	And Selecciona boton Aplicar descuento
	Then Verificar error de pantalla 

@TC18
	Scenario: TC18-Visualizar establecimientos validos luego de error de no se aplico descuento
	And Aplicar Codigo de Error "62"
	Given Selecciona opcion parking directo
	When Selecciona boton Continuar 
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	When Selecciona opcion Aplicar un descuento
	And Selecciona boton Aplicar descuento
	When Seleccionar Validar Ticket de compra luego de Error al aplicar descuento
	Then Visualizar Establecimientos validos

@TC19
Scenario: TC19-Validar que al dar clic en botón continuar muestre pantalla de escanear qr o subir qr desde galeria
	Given Selecciona opcion parking
	When Selecciona boton Continuar
	Then Visualiza Subir codigo QR

@TC20
Scenario: TC20-Validar mensaje de conoce los establecimientos validos
	Given Selecciona opcion parking
	When Selecciona boton Continuar 
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	Then Visualiza opcion Validar ticket de compra
	When Selecciona opcion Validar ticket de compra
	Then Visualiza modal Establecimientos validos

@TC23
Scenario: TC23-Validar historial de pagos despues de haber realizado un pago exitoso
	Given Selecciona opcion parking
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
	Then Visualiza pantalla Pago exitoso
	When Realiza scroll hasta Ver mi historial de pagos
	Given Selecciona opcion Ver mi historial de pagos
	Then Visualiza Historial de pagos
	And Visualiza que el ultimo monto pagado sea correcto

@TC24
Scenario: TC24-Validar pago despues de haber realizado un pago exitoso monto 0 soles
	Given Selecciona opcion parking
	When Selecciona boton Continuar 
	When Selecciona Subir codigo QR
	When Escanea QR correcto 2
	When Selecciona boton Pagar estacionamiento
	Then Visualiza checkbox de terminos y condiciones
	When Marca checkbox de terminos y condiciones
	When Selecciona boton Pagar
	Then Visualiza modal Importante
	When Selecciona boton Continuar
	Then Visualiza pantalla Pago exitoso

@TC26
Scenario: TC26-Subir imagen incorrecta desde galeria
	Given Selecciona opcion parking
	When Selecciona boton Continuar
	When Selecciona Subir codigo QR
	When Escanea QR incorrecto

@TC27
Scenario: TC27-Validar escanear qr  desde ticket de compra
	Given Selecciona opcion parking
	When Selecciona boton Continuar
	When Selecciona Subir codigo QR
	When Escanea QR incorrecto
	Then Visualiza mensaje UPS Error de imagen

@TC32
Scenario: TC32-Boton aplicar descuento y monto
	Given Selecciona opcion parking
	When Selecciona boton Continuar
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	Then Visualiza opcion Aplicar un descuento
	And Visualiza monto a pagar

@TC33
Scenario: TC33-Verificar al dar clic en aplicar descuento muestre un modal con imagen
	Given Selecciona opcion parking
	When Selecciona boton Continuar
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	When Selecciona opcion Aplicar un descuento
	Then Visualiza modal Aplicar un descuento

@TC34
Scenario: TC34-Validar que al dar clic terminos y condiciones muestre modal
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
	Given Selecciona opcion parking
	When Selecciona boton Continuar
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	When Selecciona opcion Aplicar un descuento
	Then Visualiza modal Aplicar un descuento
	When Selecciona boton Aplicar descuento
	Then Visualiza mensaje Felicitaciones se aplico el descuento exitosamente

@TC38
Scenario: TC38-Verificar al no seleccionar terminos y condiciones no se activar el boton pagar
	Given Selecciona opcion parking
	When Selecciona boton Continuar
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	When Selecciona boton Pagar estacionamiento
	Then Visualiza boton Pagar deshabilitado de estacionamiento

@TC39
Scenario: TC39-Verificar que al marcar terminos y condiciones se active el boton de pagar
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
	Given Selecciona opcion parking
	When Selecciona boton Continuar
	When Selecciona Subir codigo QR
	When Escanea QR correcto 3
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