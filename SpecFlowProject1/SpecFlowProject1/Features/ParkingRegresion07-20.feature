Feature: Ejecucion de casos de pruebas de regresi�n 20/07

Scenario: TC03: Validar registro de usuario con parking
	Given El usuario ingresa como invitado
	And Selecciona opcion parking
	Then Visualiza pantalla de Login
	When Selecciona opcion Registrate
	Then Visualiza pantalla Registro

Scenario: TC04: Validar modal informativo de establecimientos validos en ticket de compra
	Given El usuario se logea al app
	And Selecciona opcion parking
	When Selecciona boton Continuar 
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	Then Visualiza opcion Validar ticket de compra
	When Selecciona opcion Validar ticket de compra
	Then Visualiza modal Establecimientos validos

Scenario: TC05: Validar historial de pagos despues de haber realizado un pago exitoso
	Given El usuario se logea al app
	And Selecciona opcion parking
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

Scenario: TC06: Validar historial de pagos despues de haber realizado un pago exitoso monto 0 soles
	Given El usuario se logea al app
	And Selecciona opcion parking
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
	Given Selecciona opcion Ver mi historial de pagos
	Then Visualiza Historial de pagos
	And Visualiza ultimo pago de S/0.00

Scenario: TC07: Validar historial de pagos despues de haber realizado un pago rechazado
	Given El usuario se logea al app
	And Selecciona opcion parking
	When Selecciona boton Continuar 
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	When Selecciona boton Pagar estacionamiento
	Then Visualiza checkbox de terminos y condiciones
	When Marca checkbox de terminos y condiciones
	When Selecciona boton Pagar
	Then Visualiza modal Importante
	When Selecciona boton Continuar
	Then Visualiza modal Elige un medio de pago
	When Selecciona tarjeta como medio de pago
	Then Visualiza formulario Pago con tarjeta
	When Llena formulario con los datos de la tarjeta sin fondos
	And Selecciona monto a pagar
	Then Visualiza pantalla Pago rechazado
	When Selecciona link Ir a inicio
	Given Selecciona opcion Ver mi historial de pagos
	Then Visualiza Historial de pagos
	And Visualiza pagos rechazado en color rojito

Scenario: TC08: Validar mensaje de error de poca iluminacion en scanner de establecimiento
	Given El usuario se logea al app
	And Selecciona opcion parking
	When Selecciona boton Continuar 
	When Selecciona Subir codigo QR
	When Escanea QR incorrecto
	Then Visualiza mensaje UPS Error de imagen
	
Scenario: TC09: Validar mensaje de error de falla de red en scanner de establecimiento

Scenario: TC10: Validar mensaje de error de falla de servicios en scanner de establecimiento

Scenario: TC11: Validar mensaje de error de poca iluminacion en ticket de compra

Scenario: TC12: Validar mensaje de error de falla de red en ticket de compra

Scenario: TC13: Validar mensaje de error de falla de servicios en ticket de compra

Scenario: TC14: Validar mensaje de ticket de compra no valido en ticket de compra

Scenario: TC15: Validar mensaje de lo sentimos no se ha podido aplicar el descuento en aplicar descuento

Scenario: TC16: Validar mensaje de se agoto la promocion en aplicar descuentos

Scenario: TC17: Validar que al hacer clic en el boton pagar  muestre la pantalla de error de servicios

Scenario: TC18: Validar que al realizar el pago exitoso muestra falla de red con cuenta regresiva y se recupere correctamente
	Given El usuario se logea al app
	And Aplicar Codigo de Error "8"
	And Selecciona opcion parking directo
	When Selecciona boton Continuar 
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	And Selecciona opcion Aplicar un descuento
	Then Visualiza modal Aplicar un descuento
	When Selecciona boton Aplicar descuento
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
	Then Visualiza mensaje Ups Ha ocurrido un error en la confirmacion del pago
	Then Visualiza pantalla Pago exitoso

Scenario: TC19: Validar que al realizar el pago exitoso muestra falla de red con cuenta regresiva y no eres tu somos nosotros
	Given El usuario se logea al app
	And Aplicar Codigo de Error "7"
	And Selecciona opcion parking directo
	When Selecciona boton Continuar 
	When Selecciona Subir codigo QR
	When Escanea QR correcto
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
	Then Visualiza mensaje Ups Ha ocurrido un error en la confirmacion del pago
	And Visualiza pantalla de enchufe y numero de transaccion