import Vue from 'vue'
import Router from 'vue-router'
import Home from './views/Home.vue'
import Productos from "./components/Productos.vue"
import Ventas_Articulo from "./components/Ventas/Ventas_Articulo.vue"
import Ventas from "./components/Ventas/Ventas.vue";

Vue.use(Router)

export default new Router({
  mode: 'history',
  base: process.env.BASE_URL,
  routes: [
    {
      path: '/',
      name: 'home',
      component: Home
    },
    {
      path: '/productos',
      name: 'productos',
      component: Productos
    },
    {
      path: '/ventas/articulo',
      name: 'ventas_articulo',
      component: Ventas_Articulo
    },
    {
      path: '/ventas',
      name: 'ventas',
      component: Ventas
    }
  ]
})
