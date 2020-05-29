
CREATE TABLE Produit(
   Code_article INT,
   Libelle_Article VARCHAR(255),
   qte_en_cours_commande INT,
   Stock_physique INT,
   PRIMARY KEY(Code_article)
);

CREATE TABLE Contact(
   id_contact INT,
   rue_contact VARCHAR(50),
   num_rue_contact VARCHAR(10),
   nom_contact VARCHAR(50),
   ville_contact VARCHAR(50),
   cp_contact nchar(10),
   personne_contact nvarchar(50),
   satisfaction_contact int,
   PRIMARY KEY(id_contact)
);

CREATE TABLE Commande(
   id_commande INT,
   obs_commande VARCHAR(250),
   date_commande DATE,
   id_contact INT NOT NULL,
   PRIMARY KEY(id_commande),
   FOREIGN KEY(id_contact) REFERENCES Contact(id_contact)
);

CREATE TABLE Vente(
   Code_article INT,
   id_contact INT,
   qte_vendu INT,
   pu_vente DECIMAL(15,2),
   PRIMARY KEY(Code_article, id_contact),
   FOREIGN KEY(Code_article) REFERENCES Produit(Code_article),
   FOREIGN KEY(id_contact) REFERENCES Contact(id_contact)
);

CREATE TABLE ligne_commande(
   Code_article INT,
   id_commande INT,
   num_ligne INT,
   qte_commande INT,
   prix_unitaire DECIMAL(15,2),
   qte_livre INT,
   derniere_livraison DATE,
   PRIMARY KEY(Code_article, id_commande),
   FOREIGN KEY(Code_article) REFERENCES Produit(Code_article),
   FOREIGN KEY(id_commande) REFERENCES Commande(id_commande)
);

Insert into Produit
	values
	(1, 'article1', 5, 10),
	(2, 'article2', 6, 5),
	(3, 'article3', 7, 12),
	(4, 'article4', 8, 15)
Insert into Contact
	values
	(1,'rue1', '1', 'nom1', 'ville1', '75000', 'contact1', 8),
	(2,'rue2', '2', 'nom2','ville2', '69000', 'contact2', 6),
	(3,'rue3', '3', 'nom3', 'ville3', '67000', 'contact3', 4),
	(4,'rue4', '4', 'nom4', 'ville4', '13000', 'contact4', 2)
Insert into Commande
	values
	(1,'obs1', '2000-01-01', 4),
	(2,'obs2', '2000-01-02', 3),
	(3,'obs3', '2000-01-03', 2),
	(4,'obs4', '2000-01-04', 1)
Insert into Vente
	values
	(1, 4, 10, 10),
	(2, 3, 11, 20),
	(3, 2, 12, 30),
	(4, 1, 13, 40)
Insert into ligne_commande
	values
	(1, 4, 5, 5, 12, 2, '2000-01-01'),
	(2, 3, 9, 10, 20, 4, '2000-01-02'),
	(3, 2, 16, 6, 15, 6, '2000-01-03'),
	(4, 1, 3, 3, 18, 9, '2000-01-04')
