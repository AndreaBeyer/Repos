CREATE PROCEDURE createcontact
(@pnum_rue_contact varchar(10),@pnom_contact varchar(50),@pville_contact varchar(50),@pcp_contact nvarchar(10),
@ppersonne_contact nvarchar(50),@prue_contact varchar(50),@psatisfaction_contact int, @id int output)
AS
Insert into Contact
values
(@prue_contact, @pnum_rue_contact, @pnom_contact, @pville_contact, @pcp_contact, @ppersonne_contact, @psatisfaction_contact)

set @id = @@IDENTITY

CREATE PROCEDURE SearchContact
(@pid_contact int)
AS
select id_contact From Contact where id_contact = @pid_contact

CREATE PROCEDURE SearchAllContactsByALL
AS
select * From Contact

CREATE PROCEDURE UpdateContact
(@pid_contact int, @pnum_rue_contact varchar(10),@pnom_contact varchar(50),@pville_contact varchar(50),@pcp_contact nvarchar(10),
@ppersonne_contact nvarchar(50),@prue_contact varchar(50),@psatisfaction_contact int)
AS
update Contact
set num_rue_contact = @pnum_rue_contact,
nom_contact = @pnom_contact,
ville_contact = @pville_contact,
cp_contact = @pcp_contact,
personne_contact = @ppersonne_contact,
satisfaction_contact = @psatisfaction_contact,
rue_contact = @prue_contact
where id_contact = @pid_contact




