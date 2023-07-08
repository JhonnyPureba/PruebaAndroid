Feature: Historial de Pagos

Background: 
	Given El usuario se logea al app
	And Selecciona opcion parking
	And Selecciona opcion Ver mi historial de pagos

	@TC25
	Scenario: Validar que que si el pago fue rechazado muestre monto a pagar tachado y mensaje de pago rechazado realizar un pago exitoso
	Then Visualiza Historial de pagos
	And Visualiza pagos rechazado en color rojito

