PROBLEMA:
En una aplicaci�n de una tienda online. La primera versi�n de la aplicaci�n s�lo es capaz de manejar cobros por trajeta de credito, por lo que la mayor parte del c�digo se encuentra dentro de la clase CreditCard.

Para a�adir otros metodos de pago a la aplicaci�n habr�a que hacer cambios en todo el c�digo, cada vez que esto se quiera realizar.

SOLUCION:

Con el patr�n Factory Method en lugar de llamar al operador new para construir objetos directamente cada vez que se quiere a�adir un nuevo metodo de pago, se invoca al metodo factory.CreatePaymentMethod.

Ahora se puede sobrescribir el m�todo factory.CreatePaymentMethod para a�adir metodos de pago mediante subclases, cambiar las subclases creadas por el metodo, etc.
