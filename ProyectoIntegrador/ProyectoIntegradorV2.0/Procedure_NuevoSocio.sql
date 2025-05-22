/*-------------------------------------------*/
/* ----- Procedimiento  NuevoSocio ------ */



delimiter //  
create procedure NuevoSocio(
	in Nom varchar(30),
    in Ape varchar(40),
    in Tip varchar(20), 
    in Docu int, 
    in Apt boolean, 
    in Nac date, 
    in Direc varchar(50),
    in Telef varchar(20),
    in Em varchar(50),
    out rta int
)

 begin
     declare filas int default 0;
	 declare existe int default 0;
    
    -- Se valida si hay socios registrados (se obtiene la cantidad de filas en tabla socio)
     set filas = (select count(*) from socio);
     
     
     if filas = 0 then
	/* si no hay socios registrados: se establece el n° del primer id Socio */
			set filas = 2;
            -- si set filas = 1; el primer socio se crea correctamente pero nos arroja mensaje de error.
     else
	/* Si hay registros previos: se busca el ultimo n° de idSocio almacenado 
	(para luego sumarle una unidad y considerarla como PRIMARY KEY de la tabla socio)  */
			set filas = (select max(idSocio) + 1 from socio);
		
			/* Se verifica si ya existe el socio (con el tipo y n° de doc pasados por parámetros) */	
			set existe = (
				select count(*)
				from socio s WHERE Doc = Docu
                /* si pk compuesta por tipo y n° doc:
				join cliente c on s.DocC = c.DocC
				where c.TDocC = Tip and c.DocC = Doc */
            );
	  end if;    
           
     
	  if existe = 0 then	 
			-- si no está registrado como socio: se agrega nuevo socio 
            -- se insertan datos en cliente primero (herencia)
			INSERT INTO cliente (Doc, TDoc, Nombre, Apellido, FechaNac, Direccion, Telefono, Email, AptoMedico)
			VALUES (Docu, Tip, Nom, Ape, Nac, Direc, Telef, Em, Apt);
             -- se insertan datos en socio
			INSERT INTO socio (idSocio, Doc, FechaInscripcion)
			VALUES (filas, Docu, CURDATE());

			set rta  = filas; -- se devuelve el nuevo id del socio
	  else
            -- si ya estaba previamente registrado como socio: 
			set rta = existe; -- se devuelve que ya existe (existe = 1)
      end if;		 
    
  end //

