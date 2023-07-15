// Código JavaScript para interactuar con la página

// Obtenemos todas las secciones del contenido
const secciones = document.querySelectorAll('section');

// Recorremos las secciones y agregamos un evento de clic a cada una
secciones.forEach((seccion) => {
  // Obtenemos el título y el contenido de la sección
  const titulo = seccion.querySelector('h2');
  const contenido = seccion.querySelector('p');

  // Agregamos el evento de clic al título de la sección
  titulo.addEventListener('click', () => {
    // Alternamos la clase "activo" en la sección para mostrar u ocultar el contenido
    seccion.classList.toggle('activo');

    // Cambiamos el texto del título para indicar si la sección está desplegada o no
    if (seccion.classList.contains('activo')) {
      titulo.textContent = '▼ ' + titulo.textContent;
    } else {
      titulo.textContent = '► ' + titulo.textContent;
    }
  });
});


import React from 'react';
import {
  Header,
  Nav,
  NavList,
  NavItem,
  NavLink,
  Main,
  Footer,
  Section,
  SectionTitle,
} from './Estilos';

const SitioWebInformativo = () => {
  return (
    <>
      <Header>
        <h1>Sitio Web Informativo</h1>
      </Header>

      <Nav>
        <NavList>
          <NavItem>
            <NavLink href="#categoria1">Categoría 1</NavLink>
          </NavItem>
          <NavItem>
            <NavLink href="#categoria2">Categoría 2</NavLink>
          </NavItem>
          <NavItem>
            <NavLink href="#categoria3">Categoría 3</NavLink>
          </NavItem>
        </NavList>
      </Nav>

      <Main>
        <Section id="categoria1">
          <SectionTitle>Categoría 1</SectionTitle>
          <p>Contenido de la categoría 1...</p>
        </Section>

        <Section id="categoria2">
          <SectionTitle>Categoría 2</SectionTitle>
          <p>Contenido de la categoría 2...</p>
        </Section>

        <Section id="categoria3">
          <SectionTitle>Categoría 3</SectionTitle>
          <p>Contenido de la categoría 3...</p>
        </Section>
      </Main>

      <Footer>
        <p
