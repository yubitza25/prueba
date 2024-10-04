CREATE PROC dbo.ListarPersonas
AS
BEGIN
	SELECT TOP 50 P.nombres,
				  P.apellido_materno,
				  p.apellido_paterno,
				  P.dni,
				  P.fecha_nacimiento
	FROM Persona P
END








CREATE PROC dbo.ListarAtencionesPacientes
AS
BEGIN
    SELECT TOP 50 
        A.idAtencion,
        CONCAT(Pe.nombres, ' ', Pe.apellido_paterno, ' ', Pe.apellido_materno) AS NombreCompleto,
        Pe.dni,
        D.descripcion AS DiagnosticoDescripcion,
        TOM.nombre_tipo AS TipoOrdenMedica,
        SO.costo AS CostoServicio,
        A.estado
    FROM Atencion A
    INNER JOIN Paciente P ON A.idAtencion = P.idPaciente
    INNER JOIN Persona Pe ON P.idPaciente = Pe.idPersona
    INNER JOIN Diagnostico D ON A.idAtencion = D.idDiagnostico
    INNER JOIN TipoOrdenMedica TOM ON A.idAtencion = TOM.idTipoOrdenMedica
    INNER JOIN ServiciosOfrecidos SO ON A.idAtencion = SO.id_TipoOrdenMedica
END

EXEC dbo.ListarAtencionesPacientes








CREATE PROCEDURE ListarUsuarios
AS
BEGIN
    SELECT 
        U.idUsuario, 
        U.nombre_usuario, 
        U.contrasena, 
        R.descripcion AS descripcionRol
    FROM 
        Usuario U
    INNER JOIN 
        Rol R ON U.id_Rol = R.idRol;
END;

EXECUTE ListarUsuarios






CREATE PROC dbo.ListarEspecialidad
AS
BEGIN
    SELECT E.idEspecialidad,
           E.nombre_especialidad,
           E.costo,
           CONCAT(Pe.nombres, ' ',Pe.apellido_paterno, ' ', Pe.apellido_materno) AS Nombres_Completos,
    FROM Especialidad E
    INNER JOIN Medico M ON E.id_Medico = M.idMedico
    INNER JOIN Persona Pe ON M.id_Persona = Pe.idPersona
END





CREATE PROC dbo.ListarAtencionesPacientes
AS
BEGIN
    SELECT TOP 50 
        A.idAtencion,
        CONCAT(Pe.nombres, ' ', Pe.apellido_paterno, ' ', Pe.apellido_materno) AS NombreCompleto,
        Pe.dni,
        D.descripcion AS DiagnosticoDescripcion,
        TOM.nombre_tipo AS TipoOrdenMedica,
        SO.costo AS CostoServicio,
        A.estado
    FROM Atencion A
    INNER JOIN Paciente P ON A.idAtencion = P.idPaciente
    INNER JOIN Persona Pe ON P.idPaciente = Pe.idPersona
    INNER JOIN Diagnostico D ON A.idAtencion = D.idDiagnostico
    INNER JOIN TipoOrdenMedica TOM ON A.idAtencion = TOM.idTipoOrdenMedica
    INNER JOIN ServiciosOfrecidos SO ON A.idAtencion = SO.id_TipoOrdenMedica
END

EXEC dbo.ListarAtencionesPacientes








CREATE PROC dbo.BuscarAtencionPorDni
    @dni CHAR(8)
AS
BEGIN
    SELECT 
        A.idAtencion,
        CONCAT(Pe.nombres, ' ', Pe.apellido_paterno, ' ', Pe.apellido_materno) AS NombreCompleto,
        Pe.dni,
        D.descripcion AS DiagnosticoDescripcion,
        TOM.nombre_tipo AS TipoOrdenMedica,
        SO.costo AS CostoServicio,
        A.estado
    FROM Atencion A
    INNER JOIN Paciente P ON A.idAtencion = P.idPaciente
    INNER JOIN Persona Pe ON P.idPaciente = Pe.idPersona
    INNER JOIN Diagnostico D ON A.idAtencion = D.idDiagnostico
    INNER JOIN TipoOrdenMedica TOM ON A.idAtencion = TOM.idTipoOrdenMedica
    INNER JOIN ServiciosOfrecidos SO ON A.idAtencion = SO.id_TipoOrdenMedica
    WHERE Pe.dni = @dni
END

EXEC dbo.BuscarAtencionPorDni @dni = '12345678';

