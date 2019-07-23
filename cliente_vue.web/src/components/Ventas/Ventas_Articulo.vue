<template>
  <v-layout align-start>
    <v-flex>
      <v-container fluid grid-list-md>
        <v-data-iterator
          :items="items"
          :rows-per-page-items="rowsPerPageItems"
          :pagination.sync="pagination"
          row
        >
          <template v-slot:header>
            <v-toolbar class="mb-2" color="indigo darken-5" dark flat>
              <v-toolbar-title>Ventas por Articulo</v-toolbar-title>
            </v-toolbar>
          </template>          
          <template v-slot:item="props">
            <v-flex xs12>
              <v-card>
                <v-card-title class="subheading font-weight-bold">{{ props.item.titulo }}</v-card-title>
                <v-divider></v-divider>
                <v-list dense>
                  <v-list-tile>
                    <v-list-tile-content>Cantidad:</v-list-tile-content>
                    <v-list-tile-content class="align-end">{{ props.item.cantidadVendida }}</v-list-tile-content>
                  </v-list-tile>
                </v-list>
                <v-list dense>
                  <v-list-tile>
                    <v-list-tile-content>Monto:</v-list-tile-content>
                    <v-list-tile-content class="align-end">{{ props.item.monto }}</v-list-tile-content>
                  </v-list-tile>
                </v-list>
              </v-card>
            </v-flex>
          </template>

          <template v-slot:footer>
            <v-toolbar class="mt-2" color="indigo" dark dense flat>
              <v-toolbar-title class="subheading"></v-toolbar-title>
            </v-toolbar>
          </template>
        </v-data-iterator>
      </v-container>
    </v-flex>
  </v-layout>
</template>


<script>
import axios from "axios";
export default {
  created() {
    this.listar();
  },
  methods: {
    listar() {
      let me = this;
      axios
        .get("https://localhost:44394/api/ventas/articulo")
        .then(function(response) {
          me.items = response.data;
          console.log(response);
        })
        .catch(function(error) {
          console.log(error);
        });
    }
  },

  data: () => ({
    rowsPerPageItems: [1, 5, 10],
    pagination: {
      rowsPerPage: 1
    },
    items: []
  })
};
</script>