Feature: AppiumTest
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowProject1/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Boton aplicar descuento y monto
	Given Probando app
	And usuario inicia sesion
	When el usuario selecciona parking
	And el usuario selecciona imagen de voucher
	Then Verificar el monto y boton de descuento

	@mytag
Scenario: Subir imagen incorrecta desde galeria
	Given Probando app
	And usuario inicia sesion
	When el usuario selecciona parking
	And el usuario selecciona imagen Erronea de voucher


Scenario: Verificar Modal al hacer clic en aplicar descuento
	Given Probando app
	And usuario inicia sesion
	When el usuario selecciona parking
	And el usuario selecciona imagen de voucher
	And seleccionar aplicar descuento 
	Then Verificar modal con imagen 

Scenario: Verificar al no seleccionar terminos y condiciones no se activar el boton pagar
	Given Probando app
	And usuario inicia sesion
	When el usuario selecciona parking
	And el usuario selecciona imagen de voucher
	When el usuario selecciona boton pagar
	Then Verificar que el boton de pagar este deshabilitado

Scenario: Verificar al  seleccionar terminos y condiciones se active el boton pagar
	Given Probando app
	And usuario inicia sesion
	When el usuario selecciona parking
	And el usuario selecciona imagen de voucher
	When el usuario selecciona boton pagar
	And el usuario aceptar terminos y condiciones 
	Then Verificar que el boton de pagar este habilitado

Scenario: Aplicar descuento a voucher 
	Given Probando app
	And usuario inicia sesion
	When el usuario selecciona parking
	And el usuario selecciona imagen de voucher
	When el usuario selecciona aplicar un descuento 
	And el usuario selecciona aplicar descuento
	Then Verificar que el descuento se aplique

Scenario: Error al Aplicar descuento a voucher 
	Given Probando app
	And usuario inicia sesion
	And Aplicar Codigo de Error "62"
	When el usuario selecciona parking
	And el usuario selecciona imagen de voucher
	When el usuario selecciona aplicar un descuento 
	And el usuario selecciona aplicar descuento
	Then Verificar error de pantalla 

Scenario: Desde pantalla de "no se aplico la promocion en aplicar descuento " muestra modal de establecimientos validos
	Given Probando app
	And usuario inicia sesion
	When el usuario selecciona parking
	And el usuario selecciona imagen de voucher
	When el usuario selecciona aplicar un descuento 
	And el usuario selecciona aplicar descuento
	Then Verificar error de pantalla 

Scenario: Error de servicio al aplicar descuento
	Given Probando app
	And usuario inicia sesion
	When el usuario selecciona parking
	And el usuario selecciona imagen de voucher
	When el usuario selecciona aplicar un descuento 
	And el usuario selecciona aplicar descuento
	Then Verificar error de pantalla 

Scenario: Pantalla de monto a pagar muestre mensaje de conoce los establecimientos validos aquí y al dar click muestre modal informativo 
	Given Probando app
	And usuario inicia sesion
	When el usuario selecciona parking
	And el usuario selecciona imagen de voucher
	When el usuario selecciona aplicar un descuento 
	And el usuario selecciona aplicar descuento
	Then Verificar error de pantalla 

Scenario: Verificar un pago realizado con descuento se muestre en el historial de pagos
	Given Probando app
	And usuario inicia sesion
	When el usuario selecciona parking
	And el usuario selecciona imagen de voucher
	When el usuario selecciona aplicar un descuento 
	And el usuario selecciona aplicar descuento
	Then Verificar error de pantalla 
