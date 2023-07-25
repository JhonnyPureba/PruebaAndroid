Feature: AppiumTest
Background: 
	Given El usuario se logea al app

@TC2
Scenario: Verificar Modal al hacer clic en aplicar descuento
	Given Selecciona opcion parking
	When Selecciona boton Continuar
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	When Selecciona opcion Aplicar un descuento
	Then Verificar modal con imagen 

@TC3
Scenario: Verificar al dar clic en terminos y condiciones muestre modal
	Given Selecciona opcion parking
	When Selecciona boton Continuar 
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	When Selecciona opcion Aplicar un descuento
	When Selecciona link terminos y condiciones
	Then Visualiza titulo de terminos y condiciones 

@TC5
Scenario: Aplicar descuento a voucher y verificar descuento aplicado
	Given Selecciona opcion parking
	When Selecciona boton Continuar
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	When Selecciona opcion Aplicar un descuento
	And Selecciona boton Aplicar descuento
	Then Verificar que el descuento se aplique

@TC6
Scenario: Visualizar al aplicar descuento muestre mensaje "felicitaciones, se aplico el descuento exitosamente"
	Given Selecciona opcion parking
	When Selecciona boton Continuar 
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	When Selecciona opcion Aplicar un descuento
	And Selecciona boton Aplicar descuento
	Then Visualizar el mensaje exitoso cuando el descuento se aplique

@TC8
Scenario: Verificar al  seleccionar terminos y condiciones se active el boton pagar
	Given Selecciona opcion parking
	When Selecciona boton Continuar
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	And Selecciona boton Pagar estacionamiento
	When Marca checkbox de terminos y condiciones
	Then Visualiza boton Pagar habilitado
	When Selecciona boton Pagar

@TC9
Scenario: Pago exitoso y muestre datos correctos 
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

@TC11
Scenario: Validar que al hacer clic en el boton pagar  muestre la pantalla de error de servicios
	Given El usuario se logea al app
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
	Scenario: Visualizar mensaje error no se aplico la promocion al aplicar descuento
	And Aplicar Codigo de Error "62"
	Given Selecciona opcion parking directo
	When Selecciona boton Continuar 
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	When Selecciona opcion Aplicar un descuento
	And Selecciona boton Aplicar descuento
	Then Verificar error de pantalla no aplico descuento

@TC14
Scenario: Validar modal informativo de establecimientos validos en ticket de compra
	Given El usuario se logea al app
	And Selecciona opcion parking
	When Selecciona boton Continuar 
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	Then Visualiza opcion Validar ticket de compra
	When Selecciona opcion Validar ticket de compra
	Then Visualiza modal Establecimientos validos

@TC17
	Scenario: Error de servicios al aplicar descuento 
	And Aplicar Codigo de Error "4"
	Given Selecciona opcion parking directo
	When Selecciona boton Continuar
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	When Selecciona opcion Aplicar un descuento
	And Selecciona boton Aplicar descuento
	Then Verificar error de pantalla 

@TC18
	Scenario: Visualizar establecimientos validos luego de error de no se aplico descuento
	And Aplicar Codigo de Error "62"
	Given Selecciona opcion parking directo
	When Selecciona boton Continuar 
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	When Selecciona opcion Aplicar un descuento
	And Selecciona boton Aplicar descuento
	When Seleccionar Validar Ticket de compra luego de Error al aplicar descuento
	Then Visualizar Establecimientos validos

@TC20
Scenario: Validar mensaje de conoce los establecimientos validos
	Given El usuario se logea al app
	And Selecciona opcion parking
	When Selecciona boton Continuar 
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	Then Visualiza opcion Validar ticket de compra
	When Selecciona opcion Validar ticket de compra
	Then Visualiza modal Establecimientos validos

@TC23
Scenario: Validar historial de pagos despues de haber realizado un pago exitoso
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

@TC24
Scenario: Validar pago despues de haber realizado un pago exitoso monto 0 soles
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

@TC26
Scenario: Subir imagen incorrecta desde galeria
	Given Selecciona opcion parking
	When Selecciona boton Continuar
	When Selecciona Subir codigo QR
	When Escanea QR incorrecto

@TC32
Scenario: Boton aplicar descuento y monto
	Given Selecciona opcion parking
	When Selecciona boton Continuar
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	Then Visualiza opcion Aplicar un descuento
	And Visualiza monto a pagar

@TC38
Scenario: Verificar al no seleccionar terminos y condiciones no se activar el boton pagar
	Given Selecciona opcion parking
	When Selecciona boton Continuar
	When Selecciona Subir codigo QR
	When Escanea QR correcto
	When Selecciona boton Pagar estacionamiento
	Then Visualiza boton Pagar deshabilitado de estacionamiento


	@PRIORITARIOTC1
	Scenario: Validar boton ver mi historial de pagos
	Given Selecciona opcion parking
	Then Verificar la visualizacion del boton Ver mi historial de pagos

	@PRIORITARIOTC2
	Scenario: Validar al dar click en boton muestre el historial de pagos
	Given Selecciona opcion parking
	Then Verificar la visualizacion del boton Ver mi historial de pagos
	Given Selecciona opcion Ver mi historial de pagos
	Then Visualiza Historial de pagos

	@PRIORITARIOTC9
	Scenario: Validar paginacion en historial de pagos
	Given Selecciona opcion parking
	Then Verificar la visualizacion del boton Ver mi historial de pagos
	Given Selecciona opcion Ver mi historial de pagos
	Then Verificar la paginacion en historial de pagos

	@PRIORITARIOTC12
	Scenario: Historial Pago Error de servicio desde mi cuenta
	And Aplicar Codigo de Error "12"
	Given Selecciona opcion Mi cuenta directo
	When Selecciona Mis pagos de estacionamiento
	Then Visualiza Error en el Historial de pagos

	@PRIORITARIOTC13
	Scenario: Historial Pago Error de servicio desde parking 
	And Aplicar Codigo de Error "12"
	Given Selecciona opcion parking directo
	Given Selecciona opcion Ver mi historial de pagos
	Then Visualiza Error en el Historial de pagos
