Feature: Historial de Pagos

Background: 
	Given El usuario se logea al app
	And Selecciona opcion parking

	@TC25
	Scenario: Validar que que si el pago fue rechazado muestre monto a pagar tachado y mensaje de pago rechazado realizar un pago exitoso
	And Selecciona opcion Ver mi historial de pagos
	Then Visualiza Historial de pagos
	And Visualiza pagos rechazado en color rojito

	#parking historial
	@TC3
	Scenario: Validar  que al acceder a historial de pagos y dar clic en un pago con precio de estacionamiento muestre detalle
	And Selecciona opcion Ver mi historial de pagos
	Then Visualiza Historial de pagos
	When Selecciona un pago
	Then Visualiza detalle del pago

	@TC11
	Scenario: Validar sin conexión a internet al ver historial de pagos de estacionamiento  desde parking
	When Se pierde conexion
	And Selecciona Mis pagos de estacionamiento
	Then Visualiza mensaje Ups Sin conexion a internet