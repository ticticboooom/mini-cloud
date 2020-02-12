import Vue from 'vue'
import VueRouter, { Route } from 'vue-router'

Vue.use(VueRouter)

const routes = [
  {
    path: '/account/login',
    component: () => import('@/views/Login.vue')
  },
  {
    path: '/account/register',
    component: () => import('@/views/Register.vue')
  }
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router
