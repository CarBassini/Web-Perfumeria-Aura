@charset "UTF-8";
@font-face {
  font-family: Garamond Italic;
  src: url(../assets/EBGaramond-Italic-VariableFont_wght.ttf);
}
@font-face {
  font-family: Garamond;
  src: url(../assets/EBGaramond-VariableFont_wght.ttf);
}
* {
  max-width: 100%;
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}

html, body {
  width: 100%;
}

main {
  height: auto;
}

footer, header .encabezado {
  display: flex;
  flex-flow: row wrap;
  justify-content: space-between;
  align-items: center;
}

header .encabezado h1 {
  font-size: 8vh;
  font-weight: bold;
  padding: 2vh;
  flex: 1;
  text-align: start;
}

main h2 {
  font-weight: bold;
  font-size: 5vh;
  padding-top: 5vh;
  padding-left: 2vw;
}

main h3 {
  height: 15vh;
  font-size: 4vh;
  display: flex;
  justify-content: center;
  align-items: center;
}

main .preguntas p, main p, header .envios p {
  font-family: Garamond;
  font-size: 4vh;
  color: black;
  text-align: justify;
}

header .envios {
  background-color: #8D253E;
  display: block;
}
header .envios #envios {
  font-family: Garamond;
  color: #FCFCF2;
  font-size: 3vh;
  text-align: center;
}
header .encabezado {
  width: 100%;
  height: 15vh;
  margin: 0;
  padding: 1vh;
  margin-bottom: 3vh;
}
header .encabezado #Logo {
  height: 10vh;
  width: auto;
  padding-bottom: 1vh;
}
header .encabezado h1 {
  font-family: Garamond Italic;
  color: #8D253E;
}
header .encabezado ul {
  display: flex;
  gap: 0.5vh;
  padding: 1%;
  width: 40%;
  height: 3vh;
}
header .encabezado ul li {
  list-style: none;
}
header .encabezado ul li a {
  text-decoration: none;
  color: #000;
  font-family: Garamond;
  font-size: 3vh;
  font-weight: bold;
}
@media (max-width: 430px) {
  header header .envios #envios {
    font-size: 1vh;
  }
  header header .encabezado {
    flex-wrap: wrap;
    justify-content: center;
  }
  header header .encabezado ul {
    flex: 1 1 100%;
    justify-content: center;
    gap: 2vh;
  }
  header header ul {
    flex-wrap: wrap;
    font-size: 2vh;
  }
  header header .encabezado #Logo {
    height: 5vh;
  }
  header header h1 {
    font-size: 4vh;
  }
}

/*        
        flex-direction: column;
        align-items: center;
        height: auto;
        padding: 2vh 1vh;
        #Logo {
            height: 8vh;
            padding-bottom: 0;
        }

        h1 {
            font-size: 4vh;
            text-align: center;
        } 

        ul {
            flex-direction: column;
            align-items: center;
            width: 100%;
            height: auto;
            gap: 1vh;
                li a {
                    font-size: 2.5vh;
                }
        }
    }
*/
footer {
  background-color: #8D253E;
  width: 100%;
  height: 7vh;
}
footer .derechos {
  font-family: Garamond;
  font-size: 3vh;
  color: black;
  font-weight: bold;
  margin: auto;
}
footer .redes {
  margin-right: 3vw;
}
footer .redes a {
  text-decoration: none;
  color: #000;
  font-family: Garamond;
  font-size: 3vh;
  font-weight: bold;
}
footer .redes a .rrss {
  width: 5vh;
  height: auto;
  padding: 1vh;
}
@media (max-width: 430px) {
  footer footer {
    height: 4vh;
  }
  footer footer .derechos {
    font-size: 2vh;
  }
  footer footer .redes a {
    font-size: 2vh;
  }
  footer footer .redes a .rrss {
    width: 3vh;
  }
}

main h2 {
  font-family: Garamond;
}
main .articulos {
  display: grid;
  grid-template-columns: 1fr 1fr 1fr;
  justify-items: center;
  row-gap: 10vh;
}
main .articulos article {
  width: 50vh;
  height: 60vh;
  background-color: white;
  border-radius: 15px;
  box-shadow: 0 6px 16px rgba(0, 0, 0, 0.1019607843);
  position: relative;
  margin: 10px;
  justify-content: space-between;
  padding: 2vh;
  display: grid;
  grid-template-columns: 4fr 1fr;
  grid-template-rows: 60% 15% 15% 10%;
}
main .articulos article .perfume {
  width: 80%;
  height: auto;
  padding: 10px;
  grid-column: 1/3;
  grid-row: 1/2;
  justify-self: center;
}
main .articulos article .nombre {
  font-family: Garamond;
  font-size: 3.5vh;
  color: #8D253E;
  text-align: center;
  grid-column: 1/3;
  grid-row: 2/3;
  margin: 0;
  align-items: center;
}
main .articulos article .precio {
  font-family: Garamond;
  font-size: 4vh;
  color: #8D253E;
  font-weight: bold;
  text-align: center;
  grid-column: 1/3;
  grid-row: 3/4;
  margin: 0;
  align-self: center;
}
main .articulos article .boton {
  border-style: solid;
  border-color: #8D253E;
  border-radius: 999px;
  padding: 0.5vh 2vw;
  margin: 0;
  grid-row: 4/5;
  grid-column: 1/3;
  align-self: center;
  justify-self: center;
  font-family: Garamond;
  font-size: 2vh;
  font-weight: bold;
  color: #8D253E;
}
main .articulos article .boton:hover {
  background-color: #8D253E;
  font-family: Garamond;
  font-size: 2vh;
  font-weight: bold;
  color: #FCFCF2;
}
@media (max-width: 430px) {
  main .articulos {
    grid-template-columns: 1fr;
    row-gap: 3vh;
  }
}

main h3 {
  font-family: Garamond;
  color: #FCFCF2;
}
main .femeninas {
  background-image: url(../assets/backfem.jpg);
  background-size: cover;
}
main .masculinas {
  background-image: url(../assets/backmasc.jpg);
  background-size: cover;
}
main .articulos {
  display: grid;
  grid-template-columns: 1fr 1fr 1fr;
  justify-items: center;
  row-gap: 10vh;
}
main .articulos article {
  width: 50vh;
  height: 60vh;
  background-color: white;
  border-radius: 15px;
  box-shadow: 0 6px 16px rgba(0, 0, 0, 0.1019607843);
  position: relative;
  margin: 10px;
  justify-content: space-between;
  padding: 2vh;
  display: grid;
  grid-template-columns: 4fr 1fr;
  grid-template-rows: 60% 15% 15% 10%;
}
main .articulos article .perfume {
  width: 80%;
  height: auto;
  padding: 10px;
  grid-column: 1/3;
  grid-row: 1/2;
  justify-self: center;
}
main .articulos article .nombre {
  font-family: Garamond;
  font-size: 3.5vh;
  color: #8D253E;
  text-align: center;
  grid-column: 1/3;
  grid-row: 2/3;
  margin: 0;
  align-items: center;
}
main .articulos article .precio {
  font-family: Garamond;
  font-size: 4vh;
  color: #8D253E;
  font-weight: bold;
  text-align: center;
  grid-column: 1/3;
  grid-row: 3/4;
  margin: 0;
  align-self: center;
}
main .articulos article .boton {
  border-style: solid;
  border-color: #8D253E;
  border-radius: 999px;
  padding: 0.5vh 2vw;
  margin: 0;
  grid-row: 4/5;
  grid-column: 1/3;
  align-self: center;
  justify-self: center;
  font-family: Garamond;
  font-size: 2vh;
  font-weight: bold;
  color: #8D253E;
}
main .articulos article .boton:hover {
  background-color: #8D253E;
  font-family: Garamond;
  font-size: 2vh;
  font-weight: bold;
  color: #FCFCF2;
}
@media (max-width: 430px) {
  main main .articulos {
    grid-template-columns: 1fr;
    row-gap: 3vh;
  }
}

main h2 {
  font-family: Garamond;
  color: #000;
}
main .quienessomos {
  height: 80vh;
  display: grid;
  grid-template-columns: 3fr 1fr;
  grid-template-rows: 1fr 2fr;
  column-gap: 2vw;
  row-gap: 2vh;
  align-items: center;
}
main .quienessomos .somos {
  font-size: 5vh;
  grid-column: 1/3;
  grid-row: 1/2;
  align-self: end;
}
main .quienessomos .textosomos {
  grid-column: 1/2;
  grid-row: 2/3;
  margin-left: 2vw;
}
main .quienessomos .dueños {
  height: 50vh;
  width: auto;
  grid-column: 2/3;
  grid-row: 2/3;
}
main .nuestrahistoria {
  display: grid;
  grid-template-columns: 1fr 3fr;
  grid-template-rows: 1fr 3fr;
  column-gap: 2vw;
  row-gap: 2vh;
  align-items: center;
}
main .nuestrahistoria .historia {
  font-size: 5vh;
  grid-column: 1/3;
  grid-row: 1/2;
}
main .nuestrahistoria .textohistoria {
  grid-column: 2/3;
  grid-row: 2/3;
  margin-right: 2vw;
}
main .nuestrahistoria .laboratorio {
  height: 50vh;
  width: auto;
  grid-column: 1/2;
  grid-row: 2/3;
  margin-left: 2vw;
}
@media (max-width: 430px) {
  main main .quienessomos {
    height: 50vh;
  }
  main main .quienessomos .somos {
    font-size: 4vh;
  }
  main main .quienessomos .textosomos {
    font-size: 2vh;
  }
  main main .quienessomos .dueños {
    height: 30vh;
  }
  main main .nuestrahistoria {
    height: 50vh;
    grid-template-rows: 1fr 2fr 1fr;
    margin-top: 10vh;
  }
  main main .nuestrahistoria .historia {
    font-size: 4vh;
  }
  main main .nuestrahistoria .laboratorio {
    height: 40vh;
    grid-column: 1/3;
    grid-row: 3/4;
  }
  main main .nuestrahistoria .textohistoria {
    font-size: 2vh;
    grid-column: 1/3;
    grid-row: 2/3;
    margin: 0 2vw;
  }
}

main h2 {
  font-family: Garamond;
  color: #000;
  font-weight: bold;
  font-size: 5vh;
  padding-top: 5vh;
  padding-left: 2vw;
}
main .perfil {
  height: 70vh;
  width: 80vw;
  background-color: #FCFCF2;
  border-style: ridge;
  border-radius: 15px;
  display: block;
  padding: 2vw;
  margin: auto;
}
main .perfil .dato {
  font-family: Garamond;
  font-size: 3vh;
  padding: 2vh;
}
main .perfil .registro {
  font-family: Garamond;
  font-size: 3vh;
  margin-top: 4vh;
  margin-left: 6vw;
  padding: 1vh;
}
@media (max-width: 430px) {
  main h2 {
    font-size: 3vh;
    padding-top: 3vh;
    padding-left: 1vw;
  }
  main .dato {
    font-size: 2vh;
  }
  main .registro {
    font-size: 2vh;
  }
}

main form {
  display: flex;
  flex-direction: column;
}
main h2 {
  font-family: Garamond;
  color: #000;
  font-weight: bold;
  font-size: 5vh;
  padding-top: 5vh;
  padding-left: 2vw;
}
main .preguntas {
  margin-left: 2vw;
}
main .preguntas .pregunta {
  font-family: Garamond font-size 4vh;
  color: black;
  font-weight: bold;
}
main .preguntas .respuesta {
  font-family: Garamond font-size 3vh;
  color: black;
}
@media (max-width: 430px) {
  main .preguntas .pregunta {
    font-family: Garamond font-size 3vh;
  }
  main .preguntas .respuesta {
    font-family: Garamond font-size 2vh;
  }
}

* {
  max-width: 100%;
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}

main {
  height: auto;
}

/*# sourceMappingURL=styles.cs.map */
