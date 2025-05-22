/*-------------------------------------------*/
/* ----- Procedimiento  NuevoSocio ------ */



delimiter //  
create procedure NuevoSocio(
	in Nom varchar(30),
    in Ape varchar(40),
    in Tip varchar(20), 
    in Doc int, 
    in Apt varchar(20), 
    in Nac date, 
    out rta int
)

 begin
     declare filas int default 0;
	 declare existe int default 0;
    
    -- Validar si hay socios registrados (se obtiene la cantidad de filas en tabla socio)
     set filas = (select count(*) from socio);
     if filas = 0 then
			/* si no hay socios registrados: se establece el n° del primer id Socio */
			set filas = 32; 
     else
            /* Si hay registros previos: se busca el ultimo n° de idSocio almacenado 
           (para luego sumarle una unidad y considerarla como PRIMARY KEY de la tabla socio)  */
			set filas = (select max(idSocio) + 1 from socio);
		
			/* Verificar si ya existe el socio con el tipo y n° de doc pasados por parámetros */	
			set existe = (
				select count(*)
				from socio s WHERE DocC = Doc
                /* si pk compuesta por tipo y n° doc:
				join cliente c on s.DocC = c.DocC
				where c.TDocC = Tip and c.DocC = Doc */
            );
	end if;    
           
     
	  if existe = 0 then	 
			-- si no está registrado como socio: se agrega nuevo socio 
            -- se insertan datos en cliente primero (herencia)
			INSERT INTO cliente (DocC, TDocC, NombreC, ApellidoC, FechaNac)
			VALUES (Doc, Tip, Nom, Ape, Nac);
             -- se insertan datos en socio
			INSERT INTO socio (idSocio, AptoMedico, DocC)
			VALUES (filas, Apt, Doc);

			set rta  = filas; -- se devuelve el nuevo idSocio
	  else
            -- si ya estaba registrado como socio: 
			set rta = existe; -- se devuelve que ya existe (existe = 1)
      end if;		 
    
  end //
