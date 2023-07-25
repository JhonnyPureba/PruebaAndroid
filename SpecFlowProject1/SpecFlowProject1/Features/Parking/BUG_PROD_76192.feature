Feature: BUG_PROD 76192 Error al mostrar historial de pago - Parking
Background: 
	Given El usuario se logea al app

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
