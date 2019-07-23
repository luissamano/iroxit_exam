<template>
  <v-layout align-start>
    <v-flex>
      <v-data-table
        :headers="headers"
        :items="productos"
        :search="search"
        class="elevation-1"
        hide-actions
        hide-headers
      >
        <template v-slot:items="props">
          <td>{{ props.item.idVentas }}</td>
          <td class="text-xs-start">{{ props.item.idProductos }}</td>
          <td class="text-xs-start">{{ props.item.cantidadVendida }}</td>
          <td class="text-xs-start">{{ props.item.fecha }}</td>
        </template>

        <template v-slot:no-data>
          <v-progress-circular :size="70" :width="7" color="pink" indeterminate></v-progress-circular>
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
        { text: "ID Venta", value: "idVentas" },
        { text: "ID del Producto", value: "idProductos" },
        { text: "Cantidad Vendida", value: "cantidadVendida" },
        { text: "Fecha", value: "fecha" }
      ],
      search: "",
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
        .get("https://localhost:44394/api/ventas")
        .then(function(response) {
          console.log(response);
          me.productos = response.data;
        })
        .catch(function(error) {
          console.log(error);
        });
    },
    editItem(item) {},
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

<style lang="stylus" scoped>
  .v-progress-circular
    margin: 1rem
</style>
 