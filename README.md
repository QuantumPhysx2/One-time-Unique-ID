# One-time-Unique-ID

Upon adding the following sections to the respective models of interest, Add-Migration then Update-Database your project.
<br />
<br />
Note: the project may automatically create an input for the <MODEL>Id. If this is the case, you will have to double check to ensure you cannot set the ProductId yourself during testing. Additionally, you will have to remove the Model Bindings within the generated Controller file. Otherwise, it will render the Data Annotation useless.
<br />
<br />
Finally, you SHOULD NOT assign the getter of the <Model>Id with creating a Guid. This is because the Guid will <b>constantly</b> create a new unique ID everytime you load the page, making it virtually impossible for you to do any CRUD actions with the existing record(s).
