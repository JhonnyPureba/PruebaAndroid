﻿Feature: AppiumTest
Background: 
	Given El usuario se logea al app

@TC32
Scenario: Boton aplicar descuento y monto
	Given Selecciona opcion parking
	When Selecciona boton Continuar
	When el usuario selecciona imagen de voucher
	Then Visualiza opcion Aplicar un descuento
	And Visualiza monto a pagar

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

	@TC17
	Scenario: Error de servicios al aplicar descuento 
	And Aplicar Codigo de Error "4"
	Given Selecciona opcion parking directo
	When Selecciona boton Continuar
	When el usuario selecciona imagen de voucher
	When Selecciona opcion Aplicar un descuento
	And Selecciona boton Aplicar descuento
	Then Verificar error de pantalla 

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


#faltaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
@TC26
Scenario: Subir imagen incorrecta desde galeria
	Given Selecciona opcion parking
	When Selecciona boton Continuar
	When el usuario selecciona imagen Erronea de voucher

@TC2
Scenario: Verificar Modal al hacer clic en aplicar descuento
	Given Selecciona opcion parking
	When Selecciona boton Continuar
	When el usuario selecciona imagen de voucher
	When Selecciona opcion Aplicar un descuento
	Then Verificar modal con imagen 

@TC38
Scenario: Verificar al no seleccionar terminos y condiciones no se activar el boton pagar
	Given Selecciona opcion parking
	When Selecciona boton Continuar
	When el usuario selecciona imagen de voucher
	When Selecciona boton Pagar estacionamiento
	Then Visualiza boton Pagar deshabilitado de estacionamiento

@TC8
Scenario: Verificar al  seleccionar terminos y condiciones se active el boton pagar
	Given Selecciona opcion parking
	When Selecciona boton Continuar
	When el usuario selecciona imagen de voucher
	And Selecciona boton Pagar estacionamiento
	When Marca checkbox de terminos y condiciones
	Then Visualiza boton Pagar habilitado
	When Selecciona boton Pagar


@TC5
Scenario: Aplicar descuento a voucher y verificar descuento aplicado
	Given Selecciona opcion parking
	When Selecciona boton Continuar
	When el usuario selecciona imagen de voucher
	When Selecciona opcion Aplicar un descuento
	And Selecciona boton Aplicar descuento
	Then Verificar que el descuento se aplique


@TC2
Scenario: Verificar al dar clic en terminos y condiciones muestre modal
	Given Selecciona opcion parking
	And Selecciona opcion continuar
	When el usuario selecciona imagen de voucher
	When Selecciona opcion Aplicar un descuento
	When Selecciona link terminos y condiciones
	Then Visualiza titulo de terminos y condiciones 

@TC6
Scenario: Visualizar al aplicar descuento muestre mensaje "felicitaciones, se aplico el descuento exitosamente"
	Given Selecciona opcion parking
	And Selecciona opcion continuar
	When el usuario selecciona imagen de voucher
	When Selecciona opcion Aplicar un descuento
	And Selecciona boton Aplicar descuento
	Then Visualizar el mensaje exitoso cuando el descuento se aplique

@TC9
Scenario: Pago exitoso y muestre datos correctos 
	Given Selecciona opcion parking
	When Selecciona boton Continuar
	When el usuario selecciona imagen de voucher
	When Selecciona opcion Aplicar un descuento
	And Selecciona boton Aplicar descuento
	When Marca checkbox de terminos y condiciones
	When Selecciona boton Pagar
	And Seleccionar continuar 
	And Seleccionar metodo de pago tarjeta credito debito
	And Seleccionar boton continuar dentro de pago
	When Ingresar datos de tarjeta correctos
	Then Visualizar pago exitoso en voucher

@TC12
	Scenario: Visualizar mensaje error no se aplico la promocion al aplicar descuento
	And Aplicar Codigo de Error "62"
	Given Selecciona opcion parking directo
	And Selecciona opcion continuar
	When el usuario selecciona imagen de voucher
	When Selecciona opcion Aplicar un descuento
	And Selecciona boton Aplicar descuento
	Then Verificar error de pantalla no aplico descuento

@TC18
	Scenario: Visualizar establecimientos validos luego de error de no se aplico descuento
	And Aplicar Codigo de Error "62"
	Given Selecciona opcion parking directo
	And Selecciona opcion continuar
	When el usuario selecciona imagen de voucher
	When Selecciona opcion Aplicar un descuento
	And Selecciona boton Aplicar descuento
	When Seleccionar Validar Ticket de compra luego de Error al aplicar descuento
	Then Visualizar Establecimientos validos