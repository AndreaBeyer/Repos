CREATE TABLE Produit(
   Code_article INT IDENTITY(1,1),
   Libelle_Article VARCHAR(255),
   qte_en_cours_commande INT,
   Stock_physique INT,
   PRIMARY KEY(Code_article)
);

CREATE TABLE Contact(
   id_contact INT IDENTITY(1,1),
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
   id_commande INT IDENTITY(1,1),
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