<template>
  <div id="app">
    <v-app id="inspire">
      
      <!--- NAVIGATION DRAWER --->
      <v-navigation-drawer fixed :clipped="$vuetify.breakpoint.mdAndUp" app v-model="drawer">
        <v-list dense>
          <template>
            <v-list-tile :to="{ name: 'home' }">
              <v-list-tile-action>
                <v-icon>dashboard</v-icon>
              </v-list-tile-action>
              <v-list-tile-title>Dashboard</v-list-tile-title>
            </v-list-tile>
          </template>

          <template>
            <v-list-group>
              <v-list-tile slot="activator">
              <v-list-tile-content>
                <v-list-tile-title>Productos</v-list-tile-title>
              </v-list-tile-content>
            </v-list-tile>
            <v-list-tile :to="{ name: 'productos' }">
              <v-list-tile-action>
                <v-icon>list_alt</v-icon>
              </v-list-tile-action>
              <v-list-tile-content>
                <v-list-tile-title>
                  Inventario
                </v-list-tile-title>
              </v-list-tile-content>
            </v-list-tile>            
            </v-list-group>
          </template>

          <template>
            <v-list-group>
              <v-list-tile slot="activator">
              <v-list-tile-content>
                <v-list-tile-title>Ventas</v-list-tile-title>
              </v-list-tile-content>
            </v-list-tile>
            <v-list-tile :to="{ name: '' }">
              <v-list-tile-action>
                <v-icon>attach_money</v-icon>
              </v-list-tile-action>
              <v-list-tile-content>
                <v-list-tile-title>
                  Ventas Gral
                </v-list-tile-title>
              </v-list-tile-content>
            </v-list-tile>
            <v-list-tile :to="{ name: '' }">
              <v-list-tile-action>
                <v-icon>local_offer</v-icon>
              </v-list-tile-action>
              <v-list-tile-content>
                <v-list-tile-title>
                  Ventas por productos
                </v-list-tile-title>
              </v-list-tile-content>
            </v-list-tile> 
                              
            </v-list-group>
          </template>

        </v-list>
      </v-navigation-drawer>

      <!--- TOOLBAR --->
      <v-toolbar color="blue darken-3" dark app :clipped-left="$vuetify.breakpoint.mdAndUp" fixed>
        <v-toolbar-title style="width: 300px" class="ml-0 pl-3">
          <v-toolbar-side-icon @click.stop="drawer = !drawer"></v-toolbar-side-icon>
          <span class="hidden-sm-and-down">Punto de venta</span>
        </v-toolbar-title>

        <v-spacer></v-spacer>
        <v-btn icon>
          <v-icon>apps</v-icon>
        </v-btn>
      </v-toolbar>

      <!--- CUERPO CONTENT --->
      <v-content>
        <v-container fluid fill-height>
          <v-slide-y-transition mode="out-in">
            <router-view />
          </v-slide-y-transition>
        </v-container>
      </v-content>

    </v-app>
  </div>
</template>

<script>
export default {
  name: "App",
  
  data() {
    return {
      drawer: null
    };
  }
};
</script>
