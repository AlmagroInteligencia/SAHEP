using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SAHEP
{
    public partial class terminal_segura : Form
    {
        private string textoConsola = "";
        private int avance = 0;
        private string nombreAgente;

        private string codigo = "";

        public terminal_segura()
        {
            InitializeComponent();
        }

        
        // La siguiente funci�n se ejecuta ni bien se inicia el programa. Chequea que haya
        // datos guardados, y si no los hay, arranca desde el principio.
        private async void terminal_segura_Load(object sender, EventArgs e)
        {
            avance = verifucarAvance();
            nombreAgente = verificarNombre();
            
            if (avance == 0)
            {
                await Task.Delay(1500);
                textoConsola = "Le doy la bienvenida a la Terminal Segura de la Agencia Hiper Secreta de Esp�as.";
                txaConsola.Text = textoConsola;
                await Task.Delay(2000);
                textoConsola += "\n\nPor aqu�, y solo por aqu�, nos comunicaremos...";
                txaConsola.Text = textoConsola;
                await Task.Delay(2000);
                textoConsola += "\n\nPor favor, ingrese su nombre en el cuadro de texto que se encuentra abajo ";
                txaConsola.Text = textoConsola;

                avance = 1;
            }
            else
            {
                await Task.Delay(1500);
                textoConsola = $"Le damos la bienvenida nuevamente, agente {nombreAgente}";
                txaConsola.Text = textoConsola;
                await Task.Delay(1500);

                if (avance <= 2)
                {
                    descargarArchivoConter();

                    await Task.Delay(1000);
                    textoConsola += "\n\nLe hemos enviado un archivo, por favor rev�selo... Sin embargo, nuestras lecturas son inusuales, algo extra�o est� ocurriendo...";
                    txaConsola.Text = textoConsola;
                    await Task.Delay(1500);
                    textoConsola += "\n\nCuando haya descifrado alg�n c�digo del enemigo, introd�zcalo a continuaci�n:";
                    txaConsola.Text = textoConsola;
                    avance = 2;
                }
                else if (avance == 3)
                {
                    descargarYoutube();
                }
                else if (avance == 4)
                {
                    descargarMatrix();
                }
                else if (avance == 5)
                {
                    mostrarLink();
                }
                else if (avance == 6)
                {
                    despedida();
                }
            }

        }


        // La siguiente funci�n se ejecuta cada vez que se toca el bot�n. Seg�n haya datos guardados
        // (y seg�n el punto de avance de los mismos) comienza a ejecutarse desde donde corresponda.
        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            if(txaRespuesta.Text != "" || avance == 7)
            {
                if(avance == 1)
                {
                    descargarArchivoConter();
                    primerSaludo();
                }
                else if(avance == 2)
                {
                    verificarPrimeraPass();
                }
                else if(avance == 3)
                {
                    verificarSegundaPass();
                }
                else if(avance == 4)
                {
                    verificarTerceraPass();
                }
                else if(avance == 5)
                {
                    verificarCuartaPass();
                }
                else if(avance == 6)
                {
                    despedida();
                }
                else if(avance == 7)
                {
                    reiniciar();
                }
            }
        }


        // Abajo comienzan las funciones secundarias, ordenadas.

        private int verifucarAvance()
        {
            int estado = 0;
            TextReader archivo = new StreamReader("SAVE_NO_BORRAR_NI_EDITAR_NI_RENOMBRAR");
            string texto = archivo.ReadToEnd();
            archivo.Close();

            if(texto.Contains("colorado")) 
            {
                estado = 6;
            }
            else if (texto.Contains("negro")) 
            {
                estado = 5;
            }
            else if (texto.Contains("tito"))
            {
                estado = 4;
            }
            else if (texto.Contains("micho"))
            {
                estado = 3;
            }

            return estado;
        }

        private string verificarNombre()
        {
            TextReader archivo = new StreamReader("SAVE_NO_BORRAR_NI_EDITAR_NI_RENOMBRAR");
            string nombre = archivo.ReadLine();
            archivo.Close();

            return nombre;
        }
        
        private void descargarArchivoConter()
        {
            TextWriter archivo = new StreamWriter("Archivos_Seguros\\.conter");
            archivo.WriteLine("�Oh, glriosa d�cada la del 2000! Todo era tan hermoso.");
            archivo.WriteLine("Yo era un peque�o adolescente, sol�a ir con mis amigos al cyber.");
            archivo.WriteLine("Jug�bamos mucho al 'Conter' y al Age of Empires, dos grandes");
            archivo.WriteLine("juegos que perdurar�n por la eternidad.");
            archivo.WriteLine("Para evitar que gente random se metiera, pon�amos una");
            archivo.WriteLine("contrase�a, y siempre era la misma: chipote.");
            archivo.Close();
        }

        private async void primerSaludo()
        {
            nombreAgente = txaRespuesta.Text;
            txaConsola.Text = "";
            txaRespuesta.Text = "";
            await Task.Delay(1500);
            textoConsola = "Es un placer, Agente " + nombreAgente;
            TextWriter archivo = new StreamWriter("SAVE_NO_BORRAR_NI_EDITAR_NI_RENOMBRAR");
            archivo.WriteLine(nombreAgente);
            archivo.Close();
            txaConsola.Text = textoConsola;
            await Task.Delay(1000);
            textoConsola += "\n\nLe hemos enviado un archivo, por favor rev�selo... Sin embargo, nuestras lecturas son inusuales, algo extra�o est� ocurriendo...";
            txaConsola.Text = textoConsola;
            await Task.Delay(1500);
            textoConsola += "\n\nCuando haya descifrado alg�n c�digo del enemigo, introd�zcalo a continuaci�n:";
            txaConsola.Text = textoConsola;
            avance = 2;
        }

        private async void verificarPrimeraPass()
        {
            codigo = txaRespuesta.Text.ToLower();
            txaRespuesta.Text = "";
            textoConsola = "";
            if (codigo == "chipote")
            {
                txaConsola.Text = "Esa palabra ya figura en nuestra Base de Datos...";
                await Task.Delay(1500);
                textoConsola = "\n\nNo debe introducirla aqu�, pero s� utilizarla en otro lado. Revise bien.";
                txaConsola.Text += textoConsola;
                await Task.Delay(1500);
                textoConsola = "\n\nCuando haya descifrado alg�n c�digo del enemigo, introd�zcalo a continuaci�n:";
                txaConsola.Text += textoConsola;
            }
            else if(codigo == "micho")
            {
                txaConsola.Text = "Excelente, esta informaci�n ha sido de mucha utilidad.";
                TextWriter archivo = File.AppendText("SAVE_NO_BORRAR_NI_EDITAR_NI_RENOMBRAR");
                archivo.WriteLine(codigo);
                archivo.Close();
                avance = 3;
                await Task.Delay(2500);
                descargarYoutube();
            }
            else
            {
                txaConsola.Text = "Me temo que esa no es informaci�n relevante, siga investigando.";
                await Task.Delay(1500);
                textoConsola += "\n\nCuando haya descifrado alg�n c�digo del enemigo, introd�zcalo a continuaci�n:";
                txaConsola.Text += textoConsola;
            }
        }

        private async void descargarYoutube()
        {
            codigo = "";
            txaConsola.Text = "";
            txaRespuesta.Text = "";

            TextWriter archivo = new StreamWriter("Archivos_Seguros\\links_youtube.txt");
            archivo.WriteLine("aHR0cHM6Ly93d3cueW91dHViZS5jb20vd2F0Y2g/dj1iNndhT0l5MmJ1bw0KaHR0cHM6Ly93d3cueW91dHViZS5jb20vd2F0Y2g/dj16SkVFLTVqV3dJMA0KaHR0cHM6Ly93d3cueW91dHViZS5jb20vd2F0Y2g/dj0tNW5yX3BXRkh5NA==");
            archivo.Close();

            TextWriter archivo02 = new StreamWriter("Archivos_Seguros\\proto_codigo_obtenido.txt");
            archivo02.WriteLine("No1209xxxTenesjiji25Nada666ACM1PTMejor19901829Queyyy077poiHacer4747hgfBoludon992000xxx");
            archivo02.Close();

            await Task.Delay(1500);
            textoConsola = "Agente " + nombreAgente + ", le hemos enviado dos nuevos archivos. Uno de ellos contiene un c�digo del enemigo.";
            txaConsola.Text = textoConsola;
            await Task.Delay(1500);
            textoConsola = "\n\nSin embargo, as� como est�, no nos ha sido de utilidad.Al parecer hay que hacerle modificaciones...";
            txaConsola.Text += textoConsola;
            await Task.Delay(1500);
            textoConsola = "\n\nCreemos que en el otro archivo (links_youtube.txt) hay alguna pista sobre cu�l ser�a la modificaci�n a realizar.";
            txaConsola.Text += textoConsola;
            await Task.Delay(1500);
            textoConsola = "\n\nPero a su vez, ese archivo est� codificado. Sabemos que utilizaron un algoritmo conocido, pero a�n no sabemos cual.";
            txaConsola.Text += textoConsola;
            await Task.Delay(1500);
            textoConsola = "\n\nDeber� descifrar el contenido de ese archivo, para saber como modificar el c�digo principal enemigo (proto_codigo_obtenido.txt).";
            txaConsola.Text += textoConsola;
            await Task.Delay(1500);
            textoConsola = "\n\nCuando tenga listo el c�digo enemigo definitivo, introd�zcalo a continuaci�n:";
            txaConsola.Text += textoConsola;
        }

        private async void verificarSegundaPass()
        {
            codigo = txaRespuesta.Text;

            txaConsola.Text = "";
            txaRespuesta.Text = "";

            if (codigo == "NoTenesNadaMejorQueHacerBoludon")
            {
                txaConsola.Text = "Debo admitir que esa fue nuestra primera idea...";
                await Task.Delay(1500);
                textoConsola = "\n\nPero no ha arrojado ning�n resultado, siga investigando.";
                txaConsola.Text += textoConsola;
                await Task.Delay(1500);
                textoConsola = "\n\nRecuerde, decodifique el contenido del archivo links_youtube.txt, y seguramente obtenga una pista sobre que hacer con el contenido del archivo proto_codigo_obtenido.txt.";
                txaConsola.Text += textoConsola;
                await Task.Delay(1500);
                textoConsola = "\n\nCuando tenga listo el c�digo enemigo definitivo, introd�zcalo a continuaci�n:";
                txaConsola.Text += textoConsola;
            }
            else if (codigo == "ACM1PT")
            {
                txaConsola.Text = "Deber�a tomarse este asunto con m�s seriedad. Siga investigando.";
                await Task.Delay(1500);
                textoConsola = "\n\nRecuerde, decodifique el contenido del archivo links_youtube.txt, y seguramente obtenga una pista sobre que hacer con el contenido del archivo proto_codigo_obtenido.txt.";
                txaConsola.Text += textoConsola;
                await Task.Delay(1500);
                textoConsola = "\n\nCuando tenga listo el c�digo enemigo definitivo, introd�zcalo a continuaci�n:";
                txaConsola.Text += textoConsola;
            }
            
            else if (codigo == "tito")
            {
                txaConsola.Text = "Excelente, esta informaci�n ha sido de mucha utilidad.";
                TextWriter archivo = File.AppendText("SAVE_NO_BORRAR_NI_EDITAR_NI_RENOMBRAR");
                archivo.WriteLine(codigo);
                archivo.Close();
                avance = 4;
                await Task.Delay(2500);
                descargarMatrix();
            }
            else
            {
                textoConsola = "Me temo que eso no ha arrojado ning�n resultado, siga investigando.";
                txaConsola.Text += textoConsola;
                await Task.Delay(1500);
                textoConsola = "\n\nRecuerde, decodifique el contenido del archivo links_youtube.txt, y seguramente obtenga una pista sobre que hacer con el contenido del archivo proto_codigo_obtenido.txt.";
                txaConsola.Text += textoConsola;
                await Task.Delay(1500);
                textoConsola = "\n\nCuando tenga listo el c�digo enemigo definitivo, introd�zcalo a continuaci�n:";
                txaConsola.Text += textoConsola;
            }
        }

        private async void descargarMatrix()
        {
            codigo = "";
            txaConsola.Text = "";
            txaRespuesta.Text = "";

            TextWriter archivo = new StreamWriter("Archivos_Seguros\\matrix.txt");
            archivo.WriteLine("[5,1,11]:\n[6,0,2]:\n[3,3,1]:\n[9,0,0]:\n[2,0,11]:\n[0,0,3]:\n[1,1,5]:\n[7,1,2]:\n[4,1,9]:\n[8,1,4]:\n");
            archivo.Close();

            TextWriter archivo02 = new StreamWriter("Archivos_Seguros\\textos.txt");
            archivo02.WriteLine("Frodo Bols�n era de Los Gamos. Pero se fue a vivir a");
            archivo02.WriteLine("Bols�n Cerrado junto a su t�o Bilbo, cuando este lo");
            archivo02.WriteLine("nombr� su heredero.\n");

            archivo02.WriteLine("La verdad que todo esto es un re kilombo mal, uno lo");
            archivo02.WriteLine("intenta pero a veces se hace muy dif�cil. No se puede");
            archivo02.WriteLine("complacer a todos los hinchapelotas que te rodean a");
            archivo02.WriteLine("diario en esta vida.\n");

            archivo02.WriteLine("El que haya hombres honrados y muy trabajadores es");
            archivo02.WriteLine("algo de suma importancia para el desarrollo del pa�s.\n");

            archivo02.WriteLine("Anakin Skywalker fue un gran Caballero Jedi. Luego");
            archivo02.WriteLine("cay� al lado oscuro y se convirti� en Sith. Pero");
            archivo02.WriteLine("nadie lo quita lo bailado. �No es as�?\n");

            archivo02.WriteLine("En todo el mundo, pero sobre todo en este pa�s, nunca");
            archivo02.WriteLine("va a faltar trabajo para los contadores. Alguien siempre");
            archivo02.WriteLine("va a necesitar que le dibujen los n�meros.\n");

            archivo02.WriteLine("Una decisi�n que no puede tomarse a la ligera es si se");
            archivo02.WriteLine("va a adaptar una historieta a un formato cinematogr�fico");
            archivo02.WriteLine("o televisivo. Ambos puntos tienen sus pro y sus contras.");
            archivo02.WriteLine("Hay dos grandes cuestiones a tener en cuenta: el");
            archivo02.WriteLine("presupuesto y la duraci�n requerida. Ya veremos si");
            archivo02.WriteLine("tomaron la decisi�n correcta con EL Eternauta.\n");

            archivo02.WriteLine("La palabra contrase�a est� compuesta por 'contra' y");
            archivo02.WriteLine("'se�a', o sea, alguien te hace una se�a, y vos le ten�s");
            archivo02.WriteLine("que hacer otra se�a en respuesta.\n");

            archivo02.WriteLine("�S�lvese quien pueda! �Nos atacan los muertos vivos!\n");

            archivo02.WriteLine("Algunos dicen que nosotros descendemos de los monos. Pero");
            archivo02.WriteLine("m�s bien, somos primos de ellos.\n");

            archivo02.WriteLine("La pel�cula de Matrix es una met�fora sobre el mundo");
            archivo02.WriteLine("en el que vivimos. Todos estamos atrapados en un");
            archivo02.WriteLine("sistema del cual no podemos salir. Pero estamos tan");
            archivo02.WriteLine("arraigados a �l, que a veces incluso sin darnos cuenta");
            archivo02.WriteLine("somos nosotros mismos quienes lo sostienen.\n");
            archivo02.Close();

            TextWriter archivo03 = new StreamWriter("Archivos_Seguros\\numeros.txt");
            archivo03.WriteLine("{25,349,666,5,7,1,4,11,141,255,47,256,1990,13,4,2000,23,317,71,59,65,80,233,619,547,2010,69,983,12,631}");
            archivo03.Close();

            await Task.Delay(1500);
            textoConsola = "Agente " + nombreAgente + ", le hemos enviado tres nuevos archivos,los cuales son perfectamente legibles. No estamos seguros realmente de qu� se trate...";
            txaConsola.Text = textoConsola;
            await Task.Delay(1500);
            textoConsola = "\n\nPero estamos convencidos de que ah� adentro hay un c�digo del enemigo. Como as� tambi�n, toda la informaci�n requerida para descifrarlo.";
            txaConsola.Text += textoConsola;
            await Task.Delay(1500);
            textoConsola = "\n\nSe que no ser� una tarea f�cil... Pero tenemos plena confianza en usted.";
            txaConsola.Text += textoConsola;
            await Task.Delay(1500);
            textoConsola = "\n\nCuando tenga listo el c�digo enemigo definitivo, introd�zcalo a continuaci�n:";
            txaConsola.Text += textoConsola;
        }

        private async void verificarTerceraPass()
        {
            codigo = txaRespuesta.Text;

            txaConsola.Text = "";
            txaRespuesta.Text = "";

            if (codigo == "negro")
            {
                txaConsola.Text = "Excelente, esta informaci�n ha sido de mucha utilidad.";
                await Task.Delay(1500);
                textoConsola = "\n\n�Sab�amos que usted iba a lograrlo!";
                txaConsola.Text += textoConsola;
                TextWriter archivo = File.AppendText("SAVE_NO_BORRAR_NI_EDITAR_NI_RENOMBRAR");
                archivo.WriteLine(codigo);
                archivo.Close();
                avance = 5;
                await Task.Delay(2000);
                mostrarLink();
            }
            else
            {
                textoConsola = "Me temo que eso no ha arrojado ning�n resultado, siga investigando.";
                txaConsola.Text += textoConsola;
                await Task.Delay(1500);
                textoConsola = "\n\nSomos perfectamente conscientes de la dificultad de esta tarea, nadie m�s aqu� en la Agencia ha podido resolverlo... �Pero confiamos en que usted podr� hacerlo!";
                txaConsola.Text += textoConsola;
                await Task.Delay(1500);
                textoConsola = "\n\nCuando tenga listo el c�digo enemigo definitivo, introd�zcalo a continuaci�n:";
                txaConsola.Text += textoConsola;
            }
        }

        private async void mostrarLink()
        {
            codigo = "";
            txaConsola.Text = "";
            txaRespuesta.Text = "";

            TextWriter archivo = new StreamWriter("Archivos_Seguros\\link_descubierto_enemigo.txt");
            archivo.WriteLine("https://time-commando-alto-juego.netlify.app/");
            archivo.Close();

            await Task.Delay(1500);
            textoConsola = "Agente " + nombreAgente + ", en esta ocasi�n, vamos a pedirle que revise un sitio web.";
            txaConsola.Text = textoConsola;
            await Task.Delay(1500);
            textoConsola = "\n\nTenemos motivos para creer que es utilizado por nuestros enemigos para enviarse mensajes...";
            txaConsola.Text += textoConsola;
            await Task.Delay(1500);
            textoConsola = "\n\nPor favor, ingrese en: https://time-commando-alto-juego.netlify.app/";
            txaConsola.Text += textoConsola;
            await Task.Delay(1500);
            textoConsola = "\n\nY preste atenci�n a cualquier cosa sospechosa... En caso de que descubra algo, introd�zcalo a continuaci�n: ";
            txaConsola.Text += textoConsola;
        }

        private async void verificarCuartaPass()
        {
            codigo = txaRespuesta.Text;

            txaConsola.Text = "";
            txaRespuesta.Text = "";

            if (codigo == "colorado")
            {
                txaConsola.Text = "Excelente, esta informaci�n ha sido de mucha utilidad.";
                TextWriter archivo = File.AppendText("SAVE_NO_BORRAR_NI_EDITAR_NI_RENOMBRAR");
                archivo.WriteLine(codigo);
                archivo.Close();
                avance = 6;
                await Task.Delay(2500);
                despedida();
            }
            else
            {
                textoConsola = "Me temo que eso no ha arrojado ning�n resultado, siga investigando en https://time-commando-alto-juego.netlify.app/.";
                txaConsola.Text += textoConsola;
                await Task.Delay(1500);
                textoConsola = "\n\nCuando haya encontrado algo convincente, introd�zcalo a continuaci�n:";
                txaConsola.Text += textoConsola;
            }
        }

        private async void despedida()
        {
            codigo = "";
            txaConsola.Text = "";
            txaRespuesta.Text = "";

            await Task.Delay(1500);
            textoConsola = "�Agente " + nombreAgente + ", debemos darle nuestras felicitaciones!";
            txaConsola.Text = textoConsola;
            await Task.Delay(1500);
            textoConsola = "\n\nGracias a toda la informaci�n que nos ha ido brindando, hemos descubierto definitivamente cu�les son los planes de nuestros enemigos...";
            txaConsola.Text += textoConsola;
            await Task.Delay(1500);
            textoConsola = "\n\nRealmente estuvimos muy cerca de perderlo todo, pero ahora el mundo puede estar a salvo. Y eso va a depender de todos y cada uno de nosotros.";
            txaConsola.Text += textoConsola;
            await Task.Delay(1500);
            textoConsola = "\n\nHemos subido a internet un resumen de todos los planes de nuestros enemigos, con el fin de alertar a toda la poblaci�n mundial. Por favor, ingrese en: https://www.youtube.com/watch?v=oHg5SJYRHA0";
            txaConsola.Text += textoConsola;
            await Task.Delay(1500);
            textoConsola = "\n\nNuevamente felicitaciones, y nos contactaremos con usted cuando el mundo corra peligro nuevamente.";
            txaConsola.Text += textoConsola;
            await Task.Delay(1500);
            textoConsola = "\n\nCambio y fuera.";
            txaConsola.Text += textoConsola;

            btnEnviar.Text = "Reiniciar";
            avance = 7;
        }

        private async void reiniciar()
        {
            avance = 0;
            codigo = "";
            txaConsola.Text = "";
            txaRespuesta.Text = "";

            File.Delete("SAVE_NO_BORRAR_NI_EDITAR_NI_RENOMBRAR");
            
            TextWriter archivo = new StreamWriter("SAVE_NO_BORRAR_NI_EDITAR_NI_RENOMBRAR");
            archivo.Close();

            btnEnviar.Text = "Enviar";

            await Task.Delay(1500);
            textoConsola = "Le doy la bienvenida a la Terminal Segura de la Agencia Hiper Secreta de Esp�as.";
            txaConsola.Text = textoConsola;
            await Task.Delay(2000);
            textoConsola += "\n\nPor aqu�, y solo por aqu�, nos comunicaremos...";
            txaConsola.Text = textoConsola;
            await Task.Delay(2000);
            textoConsola += "\n\nPor favor, ingrese su nombre en el cuadro de texto que se encuentra abajo ";
            txaConsola.Text = textoConsola;

            avance = 1;
        }
    }
}
