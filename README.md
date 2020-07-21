# One-time-Unique-ID

Upon adding the following sections to the respective models of interest, Add-Migration then Update-Database your project.

Note: the project may automatically create an input for the ProductId. If this is the case, you will have to double check to ensure you cannot set the ProductId yourself during testing. Additionally, you will have to remove the Model Bindings within the generated Controller file. Otherwise, it will render the Data Annotation useless.
