import Vue from 'vue'
import Router from 'vue-router'
import Home from './views/Home.vue'
import Productos from "./components/Productos.vue";

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
    }
  ]
})
