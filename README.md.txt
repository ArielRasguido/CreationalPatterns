PROBLEMA:
En una aplicación de una tienda online. La primera versión de la aplicación sólo es capaz de manejar cobros por trajeta de credito, por lo que la mayor parte del código se encuentra dentro de la clase CreditCard.

Para añadir otros metodos de pago a la aplicación habría que hacer cambios en todo el código, cada vez que esto se quiera realizar.

SOLUCION:

Con el patrón Factory Method en lugar de llamar al operador new para construir objetos directamente cada vez que se quiere añadir un nuevo metodo de pago, se invoca al metodo factory.CreatePaymentMethod.

Ahora se puede sobrescribir el método factory.CreatePaymentMethod para añadir metodos de pago mediante subclases, cambiar las subclases creadas por el metodo, etc.
