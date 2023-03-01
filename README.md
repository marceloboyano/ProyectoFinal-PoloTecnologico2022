# ProyectoFinal-PoloTecnologico2022
Instrucciones:
1) Ejecutar el archivo proyectoFinal.sln una vez adentro cambiar la cadena de conexion en el archivo app.json.
2) Compilar el proyecto.
3) Puede crear la base de dato a travez de un script que deje en la carpeta raiz, o hacer a travez del proyecto de base de datos sql que se encuentra en la solucion,
si eligio esta ultima opción debe darle click derecho al proyecto de base de datos bingo y dale publicar. Si ya cuenta con la base de datos creada puede dirigirse a
 herramientas -consola de paquetes NuGet- consola de administrador de paquetes y poner el comando UPDATE-DATABASE
4)Ejecutar el programa y buena suerte en el juego.

Documentacion:
Es una juego bastante sencillo una vez que se ejecuta tiene un boton lanzar bolilla que es el que iniciará el juego pintandose siempre en la parte inferior la ultima bolilla, el juego termina cuando un carton llega a 15 aciertos,
en cualquier momento puede consultar las bolillas que salieron a travez del boton mostrar bolillas. Una vez que termina el juego se muestra un mensaje en amarillo, mostrando en la parte inferior el carton o los cartones ganadores.
Una vez que termina el juego se el boton de lanzar bolilla cambiara a reiniciar juego, si lo pulsa el juego iniciara nuevamente.


Como lo hice?
Utiliza una Web App con Mvc, ni bien arranca el programa el controlador del Home, llama al servicio y luego al repositorio que es donde se genera el carton y la vista del home es la encargada de mostrar ese carton, aqui utilice
algunas clases de bootstrap Html Css y js para que sea responsivo el carton asi como los textos, utilizo un componente que trae por defecto razor para reutilizar el codigo que recorre el carton,
cuando se presiona el boton lanzar bolilla ocurre la magia capturo el evento JavaScript y llamo al controller Historial bolilla hace el mismo recorrido que el controlador anterior hasta llegar al repositorio donde en este caso se 
guarda la bolilla.
En cada lanzar bolilla se recorre el carton para poder pintar las mismas y a su vez voy contando la cantidad de bolillas pintadas, en cada pasada se verifica si hubo ganador cuando el numero de bolillas pintadas es igual a 15
una vez se encontro 1 o mas ganadores se llama al ultimo controller el de Historial cartones que hace el mismo camino que los demas  y se guarda en la base de datos desde el repositorio.
Luego de guardar los cartones ganadores en la base se pinta los ganadores en el html y se da la posibilidad de reiniciar el juego, si elige esta opcion capturamos el evento
y volvemos todo a cero y sacamos las bolillas pintadas del carton.
Para los mensajes utilizo ventanas modal clasicas. los botones los decoro con clases de bootstrap. Utilizo el patron de diseño repositorio como la mayoría de mis proyectos y creo una clase singleton porque era necesario guardar el
la cantidad de bolillas que salieron y los cartones generados, por eso utilice singleton, utilice solo 2 view la que trae por default el componente para pintar los cartones y la del Home porque era un juego mas bien estatico no 
había que estar apuntando a otras vistas, lo cual me borraria el carton generado.
Cree un script desde sql de la base de datos y ademas agregue un proyecto de base de datos a la solucion tal cual como lo enseñaron en clases.

Estoy muy agradecido por lo aprendido en el curso y agradezco a todos los que hicieron posible esto!!!


								GAME OVER
