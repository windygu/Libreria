
 /*ES NECESARIO CORRER ESTA MIERDA PARA QUE PUEDA DEPLYARSE EL IDENTITY
   PARA BANCOS DESDE EL PROYECTO DE BASE DE DATOS*/
 
  UPDATE [lapaz].[dbo].[TarjetasMovimientos]
  SET BancoId = NULL
  WHERE BancoId = 0
  
  UPDATE [lapaz].[dbo].[ProveedoresBanco]
  SET BancoId = NULL
  WHERE BancoId = 0
  
  UPDATE [lapaz].[dbo].[Proveedores]
  SET ProveerdorBcoId = NULL
  WHERE ProveerdorBcoId = 0
  
   
  DELETE  FROM [lapaz].[dbo].[Bancos]
  WHERE Id = 0
  
  