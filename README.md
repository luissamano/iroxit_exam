# IroxIT Examen
Repositorio del examen tecnico de [Irox IT](http://iroxit.com).
  

📋 El proyecto fue realizado usando las siguientes tecnologias: ⚙️

- ASP.NET Core 2.2
- EntityFramework 2.2.6
- .NET Standard
- Vue 3
- Windows Presentation Foundation


> **Nota:** El repositorio esta dividivo en capas. 🔩


### Estructura del proyecto 📦

🔧El proyecto esta realizado por capas, para la mayor reutilizacion de codigo en las aplicaciones clientes WEB y Desktop. 🖇️

|  Proyecto             | Contenido          | Tools            |
|-----------------------|--------------------|------------------|
| api_aspnetcore_iroxit | Web API (Servicio) Responde via HTTPS con JSON | ASP.NET Core 2.2|
| api_aspnetcore_iroxit.DAL | Capa de acceso a datos | .NET Standard |
| api_aspnetcore_iroxit.Entities | Modelos | .NET Standard |
| cliente_vue.web | Aplicacion WEB  | Vue |
| docs_iroxit | Documentos de el examen  |   |
| SQL_Querys | Consultas en SQL  | SQL  |