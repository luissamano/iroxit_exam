<template>
  <v-layout align-start>
    <v-flex>
      <v-toolbar flat color="blue-grey lighten-5">
        <v-toolbar-title>Todos los Productos</v-toolbar-title>
        <v-divider class="mx-2" inset vertical></v-divider>

        <v-spacer></v-spacer>
        <v-text-field
          class="text-xs-center"
          v-model="search"
          append-icon="search"
          label="Buscar producto"
          single-line
          hide-details
        ></v-text-field>
        <v-spacer></v-spacer>

        <v-dialog v-model="dialog" max-width="500px">
          <template v-slot:activator="{ on }">
            <v-btn color="pink" dark class="mb-2" v-on="on" @click="listar()">Agregar un producto</v-btn>
          </template>
          <v-card>
            <v-card-title>
              <span class="headline">{{ formTitle }}</span>
            </v-card-title>

            <v-card-text>
              <v-container grid-list-md>
                <v-layout wrap>
                  <v-flex xs12 sm6 md4>
                    <v-text-field v-model="editedItem.name" label="Dessert name"></v-text-field>
                  </v-flex>
                  <v-flex xs12 sm6 md4>
                    <v-text-field v-model="editedItem.calories" label="Calories"></v-text-field>
                  </v-flex>
                  <v-flex xs12 sm6 md4>
                    <v-text-field v-model="editedItem.fat" label="Fat (g)"></v-text-field>
                  </v-flex>
                  <v-flex xs12 sm6 md4>
                    <v-text-field v-model="editedItem.carbs" label="Carbs (g)"></v-text-field>
                  </v-flex>
                  <v-flex xs12 sm6 md4>
                    <v-text-field v-model="editedItem.protein" label="Protein (g)"></v-text-field>
                  </v-flex>
                </v-layout>
              </v-container>
            </v-card-text>

            <v-card-actions>
              <v-spacer></v-spacer>
              <v-btn color="blue darken-1" flat @click="close">Cancelar</v-btn>
              <v-btn color="blue darken-1" flat @click="save">Guardar</v-btn>
            </v-card-actions>
          </v-card>
        </v-dialog>
      </v-toolbar>


      <v-data-table :headers="headers" :items="productos" :search="search" class="elevation-1">
        <template v-slot:items="props">
            
            
            <td>{{ props.item.idProductos }}</td>
            <td class="text-xs-start">{{ props.item.titulo }}</td>
            <td class="text-xs-start">{{ props.item.descripcion }}</td>
            <td class="text-xs-start">{{ props.item.precioUnitario }}</td>
            <td class="text-xs-start">{{ props.item.existencias }}</td>
            <v-spacer></v-spacer>
            <td class="justify-center layout px-0">
                <v-icon small class="mr-2" @click="editItem(props.item)">edit</v-icon>
                <v-icon small @click="deleteItem(props.item)">delete</v-icon>
            </td>
          
        </template>
        <template v-slot:no-data>
          <v-btn color="primary" @click="initialize">Reset</v-btn>
        </template>
      </v-data-table>


    </v-flex>
  </v-layout>
</template>


<script>
import axios from "axios";

export default {
  data() {
    return {
      productos: [],
      dialog: false,
      headers: [
        { text: "ID", value: "idProductos" },
        { text: "Titulo", value: "titulo" },
        { text: "Descripcion (g)", value: "descripcion" },
        { text: "Precio Unitario", value: "precioUnitario" },
        { text: "Existencias", value: "existencias"}
      ],
      search: '',
      editedIndex: -1,
      editedItem: {
        name: "",
        calories: 0,
        fat: 0,
        carbs: 0,
        protein: 0
      },
      defaultItem: {
        name: "",
        calories: 0,
        fat: 0,
        carbs: 0,
        protein: 0
      }
    };
  },
  computed: {
    formTitle() {
      return this.editedIndex === -1 ? "Nuevo Producto" : "Editar Producto";
    }
  },
  watch: {
    dialog(val) {
      val || this.close();
    }
  },
  created() {
    this.listar();
  },
  methods: {
    listar() {
        let me = this;
      axios
        .get("https://localhost:44394/api/productos")
        .then(function(response) {
          console.log(response);
          me.productos = response.data;
        })
        .catch(function(error) {
          console.log(error);
        });
    },
    editItem(item) {
      
    },
    deleteItem(item) {
        const index = this.desserts.indexOf(item);
        confirm("Estas seguro de eliminar el producto del catálogo?") &&
            this.desserts.splice(index, 1);
    },
    close() {
      this.dialog = false;
      setTimeout(() => {
        this.editedItem = Object.assign({}, this.defaultItem);
        this.editedIndex = -1;
      }, 300);
    },
    save() {
      if (this.editedIndex > -1) {
        Object.assign(this.productos[this.editedIndex], this.editedItem);
      } else {
        this.productos.push(this.editedItem);
      }
      this.close();
    }
  }
};
</script>
 