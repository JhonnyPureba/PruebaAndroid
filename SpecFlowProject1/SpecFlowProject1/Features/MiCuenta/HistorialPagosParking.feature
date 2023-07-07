Feature: Modulo Mi Cuenta

Background: 
	Given El usuario se logea al app
	And Selecciona opcion Mi cuenta

	@TC10 @HistorialParking
	Scenario: Validar sin conexión a internet al ver historial de pagos de estacionamiento desde mi cuenta
	Then Visualiza modulo MiCuenta
	When Se pierde conexion
	And Selecciona Mis pagos de estacionamiento
	Then Visualiza mensaje Ups Sin conexion a internet