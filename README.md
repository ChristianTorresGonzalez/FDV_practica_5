# Practica_05_ChristianTorresGonzalez

Para la realizacion de esta quinta práctica, partire de la escena desarrollada para la pracica anterior, de tal forma que partiendo de las implementaciones y scripts anteiores, continuare con los puntos que se solicitan. Esos puntos que se solicitan son los siguientes:
1. Implementar una UI que permita configurar con qué poder jugarás: turbo y restas una vida o normal. 
2.  Agregar a tu escena un objeto que al ser recolectado por el jugador desplace del juego un tipo de objetos que puedan representar obstáculos, a modo de barreras que abren caminos.
3. Agrega un objeto que te teletransporte a otra zona de la escena.
4. Agrega un objeto físico que muevas con las teclas wasd.
5. Agrega un personaje que se dirija hacia un objetivo estático en la escena.
6. Agrega un personajes que se dirija al objeto del apartado 4.

Como consideración, hay que tener en cuenta, que la idea de esta practica es trabajar con los delegados y los eventos. Para ponernos un poco en contexto, debemos recordar que los delegados son aquellos controladores de escena, que comunicaran algún cambio en la escena, a todas aquellas funciones, que este controlando dicho delegado. Hasta ahora sabemos lo que es un delegado, pero no sabemos como comunica a los objetos, algún cambio en la escena esto lo hará mediante los eventos. Los eventos, son esos tipos de delegados, que cuando se activan, lanzan la ejecución de todas las funciones que tienen suscritas a ellos mismo. Una vez explicado esto, entrado mas en contexto, pasemos a explicar la realización de la practica.

Tal y como se aprecia en la imagen, lo primero que hago es definir mi delegado en la línea 7, de tal forma que si en otro script quiere trabajar con alguno de los eventos implementados, solo tengo que crear un objeto de dicha clase.
 

## Menu princpipal UI


## Coleccionables por la escena
Para esta segunda tarea lo que he hecho ha sido situar en la escena una serie de capsulas que cumplirán la tarea de ser unas llaves que al recolectarlas estas nos van desbloqueando ciertas partes del mapa. Además, he implementado dos tipos de llaves:
- Llave global: este tipo de llave, se identifica con una capsula roja en la escena, y permite abrir todas las puertas en el momento que la recogemos, es decir entramos en contacto con ella.
- Llave individual: esta tipo de llave, se identifica con una capsula verde, y permite abrir la puerta que tiene asociada, pero no el resto.

Como bien comente al principio, para poder lograr cumplir alguno de los objetivos de la practica, tendría que trabajar con delegados. Es aquí donde entran en juego, para ello, en primer lugar lo que haré será crear un delegado donde definiremos los diferentes eventos a desarrollar. Una vez definido el delegado, solo nos queda definir el evento al que se suscribirán las diferentes funciones que queremos que puedan lanzar alguno de los eventos definidos.

  ![Alt text](/img/delegado.png)
  
Desarrollada la clase encargada de gestionar e implementar los delegados, ya solo nos quedaría definir la llamada al evento del delegado. Para ello lo que hago es definir un script, en el cual compruebo que tipo de llave se ha recolectado para en función de eso eliminar una puerta u otra, para pasar el tipo de llave a la ejecución de llamada del evento del delegado.

![Alt text](/img/llave.png)

Una vez definido el script para recoger la llave, para finalizar con esta tarea, solo quedaría la implementación de la función que se tiene que ejecutar cuando el evento es lanzado. Es por eso que he creado un nuevo script, el cual se encargara de eliminar la puerta, una vez se lanza el evento. En dicho script, lo primero que hago es comprobar que tipo de llave se ha recogido, para así saber si tengo que eliminar una única puerta, o por el contrario eliminar todas las puertas.
- En caso de tener que eliminar todas las puertas, lo que hago es buscar en la escena todos los objetos con la etiqueta **"Puerta"** para eliminarlos. Además de esto, también hago una segunda búsqueda de todas las llaves que hay en la escena, ya que si recogemos la llave global, el resto de llaves sobrarían, por lo que son eliminadas.
- En caso contrario, es decir, en caso de que se haya recogido una llave concreta, lo que hago es definir una nueva función, que mediante una expresión regular se encarga de determinar a que puerta esta asociada la llave que ha sido recolectada. Una vez se que puerta tiene asociada dicha llave, solo queda eliminar la puerta y la llave

![Alt text](/img/puerta.png)



## Teletransporte
El objetivo de esta segunda tarea trata de tener en la escena, algún objeto que te permita teletransportarte de un lado a otro.
Para esta tarea, lo que he hecho ha sido colocar un nuevo plano dentro de la escena, de tal forma que ahora existen dos zonas por la que poder moverse, una primera zona que es la misma que la de la practica pasada, y otra segunda zona que será la nueva donde estarán colocadas las llaves de la tarea anterior junto a las puertas que se irán abriendo. Para poder acceder a esta nueva zona lo que he hecho ha sido colocar en cada zona un objeto, en este caso una capsula que en el momento de tocarla, nos teletransportará a la otra zona. 

![Alt text](/img/teleport.png)

Tal y como se aprecia en la imagen, lo que hago es que en el momento en que algo entra en contacto con el teleport, compruebo que ha entrado en contacto, en caso de que sea el jugador, lo que hago es colocar al jugador en el punto de aparición de la zona contraria, punto el cual he definido como zona de aparición de cada escenario. Una vez he situado al jugador en las nuevas coordenadas, además también cambio la cámara a una nueva posición para que quede centrada en la nueva zona de juego. 
En caso de que vaya de la zona dos a la zona uno, seria exactamente lo mismo lo que cambiando el punto de spawn y la nueva posición de la cámara.











  - 1.a) Una vez situados los objetos en la escena, tengo que añadirle las físicas, ya que si no, estos se quedarán flotando en el aire y lo que es mas importante, no podrán colisionar con el resto de objetos, siendo este el punto clave de la práctica. Para ello, añadiré a todos los objetos la opción de Rigidbody, con la que quedarán añadidas las físicas a los objetos.

- Con esto quedaría terminado el primer punto de la practica, el cual ha consistido en formar nuestra escena con objetos sencillos y ubicarlos por nuestro plano, clasificándolos en objetos con movimiento rectilíneo y objetos que no se moverán, es decir, estáticos.




### Ejercicio 2
- 2.) En este segundo ejercicio, se nos pide que un grupo de los objetos que he colocado en la escena, al colisionar con el jugador, este salga desplazado una cantidad proporcional al poder del jugador, en la dirección en la que el jugador colisiona con el objeto.
- Para el desarrollo de este segundo punto, he implementado un script, con el cual se detectara si el objeto, en este caso he decidido que serán los cubos los que se desplazaran una cantidad proporcional al poder, ha entrado en contacto con el jugador. En caso de que hayan colisionado, se aplicará dicho desplazamiento en función del poder que tenga el jugador en ese momento. 
- He desarrollado dos script, uno perteneciente al jugador, que será el encargado de ir registrando el poder, además de contener las funciones encargadas de incrementar el poder y la función encargada de retornar el poder para usarlo en el siguiente script.
  
  ![Alt text](/img/poder.png)
  
- El siguiente script que he desarrollado para este segundo apartado, es el encargado de detectar la colisión con el jugador. En caso de que el cubo colisione con el jugador, se calculará la dirección en la que tiene que salir disparado el cubo y se aplicara dicha fuerza.
  
  ![Alt text](/img/colisionCubo.png)

- Tras el desarrollo de los scripts anteriores, este seria el resultado final

![Alt text](/img/cubo.gif)

### Ejercicio 3
- 3. Para el tercer ejercicio y cuarto ejercicio, ya que este consiste en trabajar con el mismo conjunto de objetos los explicare en este mismo punto del informe. Se pide que a los otros objetos que nos quedan en la escena, estos se moverán al entrar en contacto con el jugador, pero además de esto,  esto harán que el jugador sume puntos a su poder, por lo que cuando tocamos una esfera, se incrementa el poder, lo cual hará que al tocar un cubo este se desplace una distancia mayor. Además, cuando una esfera entra en contacto, esta deberá cambiar su color degradándolo hasta llegar a un umbral, el cual al ser superado, se eliminara dicha esfera, mientras ocurre esto, la esfera, con cada colisión deberá ir disminuyendo su tamaño.

- Para ello, lo primero que hare será desarrollar un script en el cual se detecte cuando un objeto ha entrado en colisión. En caso de que la esfera haya colisionado con el jugador, se producirán don cosas, primero se sumaran los puntos de poder al jugador, en segundo lugar se llevara a cabo el degradado de color, finalmente la tercera ejecución que se hace cuando se produce la colisión es la disminución de la escala.

![Alt text](/img/colisionEsfera.png)

- El segundo script que he desarrollando es el encargado de ir cambiando el color de la esfera, donde defino el índice de color que se va a ir degradando y el umbral que en caso de superar, provocará que se elimine el objeto. En caso de entrar en colisión, es el anterior script encargado de llamar a la función que cambia el color de la esfera.

![Alt text](/img/color.png)

- Finalmente, tras el desarrollo de los dos script anteriores, este seria el resultado final.

![Alt text](/img/esfera.gif)
