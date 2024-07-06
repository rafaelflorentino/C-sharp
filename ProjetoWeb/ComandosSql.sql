-- Lista todas as tabelas do banco
EXEC sp_help 'clientes'; 

-- Usar banco
USE projetoclientes;
GO

-- Verificar se a tabela existe
USE projetoclientes;

-- Verifica se a tabela existe
IF OBJECT_ID('clientes', 'U') IS NOT NULL
    PRINT 'A tabela clientes existe no banco de dados.';
ELSE
    PRINT 'A tabela clientes não existe no banco de dados.';

-- Lista todos os registros de clientes (ERRO)
SELECT * FROM clientes;

-- Lista todas as tabelas do banco
SELECT 
    COLUMN_NAME AS 'Nome da Coluna', 
    DATA_TYPE AS 'Tipo de Dados', 
    CHARACTER_MAXIMUM_LENGTH AS 'Tamanho Máximo' 
FROM 
    INFORMATION_SCHEMA.COLUMNS 
WHERE 
    TABLE_NAME = 'clientes';

-- Verifica todas as tabelas do banco (jeito 1)
SELECT 
    name AS 'Table Name' 
FROM 
    sys.tables;

-- Verifica todas as tabelas do banco (jeito 2)
SELECT 
    TABLE_NAME 
FROM 
    INFORMATION_SCHEMA.TABLES 
WHERE 
    TABLE_TYPE = 'BASE TABLE';

-- Verificar permissões
USE master;
GO

-- Verificar permissões para o usuário 'sa' no nível do servidor
SELECT * 
FROM sys.server_permissions
WHERE grantee_principal_id = SUSER_ID('sa');

-- Permissoes no servidor
USE master;
GO

-- Verificar permissões no nível do servidor para o usuário 'sa'
SELECT * 
FROM fn_my_permissions(NULL, 'SERVER');

-- Verificar funções de servidor às quais o
USE master;
GO

EXEC sp_helpsrvrolemember;

