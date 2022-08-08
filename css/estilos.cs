* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}

.wrapper {
  min-height: calc(100vh - 50px);
  background-color: beige;
  overflow: hidden;
  width: auto;
}
.wrapper .fondoIndex {
  background-image: url(/imagenes/fondoportada1.jpg);
  background-repeat: no-repeat;
  background-size: 50% vh;
}

header {
  background-color: rgba(124, 148, 139, 0.938);
  position: sticky;
  top: 0px;
}
header nav {
  display: flex;
  align-items: center;
  flex-direction: row;
  justify-content: center;
}
header nav ul {
  display: flex;
  list-style: none;
  width: fit-content;
  margin-left: auto;
}
header nav ul li {
  margin-left: auto;
  padding: 15px;
}
header nav ul li a {
  text-decoration: none;
  color: aliceblue;
  font-style: italic;
  font-weight: bold;
  font-size: 1.2rem;
  padding: 20px;
}
header nav ul li a:hover {
  color: black;
}
header nav ul li a:hover h1 {
  text-decoration: none;
  color: rgba(87, 93, 99, 0.801);
  font-size: 3rem;
  padding: 40px;
}

.navbar {
  background-color: rgba(124, 148, 139, 0.938);
}

h2 {
  padding: 40px;
  font-style: italic;
  font-weight: 600;
  text-align: center;
}

.article-QuienesSomos {
  padding-right: 20vw;
  padding-left: 20vw;
}

.donaciones {
  padding-right: 20vw;
  padding-left: 20vw;
}

.footer {
  width: 100%;
  height: 50px;
  background-color: rgba(124, 148, 139, 0.938);
  bottom: 0;
}
.footer a {
  text-decoration: none;
  font-size: large;
}

.flex-container {
  display: flex;
  justify-content: flex-end;
}

.formulario {
  display: flex;
  justify-content: center;
  margin: 20;
}

.container {
  display: flex;
  justify-content: center;
  margin-bottom: 0px;
}

/*.card {
    box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2);
    transition: 0.3s;
    // max-width: 300px;
    width:30%;
    border-radius: 5px;
    text-align: center;
    margin:auto;

    & :hover {
    box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2);
    transform: translateY(-15px);
    }

    img {
    border-radius: 15px 15px 0 0;
    width: 100%;
    }

    .card {
    padding: 16px 16px;
    width:30%;
    }
}


.cards-donaciones{ 
    display:flex;
    justify-content:center;
    align-items:center;


}*/
.container {
  width: 100%;
  max-width: 1200px;
  height: 430px;
  display: flex;
  flex-wrap: wrap;
  justify-content: center;
  margin: auto;
}
.container .card {
  width: 330px;
  height: 430px;
  border-radius: 8px;
  box-shadow: 0 8px 16px 0 rgba(0, 0, 0, 0.2);
  overflow: hidden;
  margin: 20px;
  text-align: center;
  transition: 0.25s;
}
.container .card :hover {
  transform: translateY(-15px);
  box-shadow: 0 8px 16px 0 rgba(0, 0, 0, 0.2);
}
.container .card img {
  width: 330px;
  height: 220px;
}
.container .card h3 {
  font-weight: 600;
}
.container .card p {
  padding: 0 1 rem;
  font-size: 16px;
  font-weight: 300;
}

@media (min-width: 320px) and (max-width: 768px) {
  .nav {
    flex-direction: column;
    justify-content: center;
  }
  .imagenes {
    width: 60%;
    margin: auto;
    justify-content: stretch;
    display: grid;
    grid-template-columns: 1fr;
    grid-template-rows: repeat(6 1fr);
    gap: 15px;
    grid-template-areas: "imag1" "imag2" "imag3" "imag4" "imag5" "imag6";
  }
}
@media (min-width: 769px) and (max-width: 1024px) {
  .nav {
    flex-direction: column;
    justify-content: center;
  }
  .imagenes {
    width: 60%;
    margin: auto;
    justify-content: stretch;
    display: grid;
    grid-template-columns: 1fr 1fr;
    grid-template-rows: repeat(3 1fr);
    gap: 15px;
    grid-template-areas: "imag1" "imag2" "imag3" "imag4" "imag5" "imag6";
  }
}
@media (min-width: 1025px) {
  .header {
    size: 100vw;
  }
}

/*# sourceMappingURL=estilos.cs.map */
