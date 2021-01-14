#include <iostream>
#include<string>

using namespace std;

class DateNaissance
{
	int jour;
	int Mois;
	int Annee;

};

class Etudiant
{
	int Matricule;
	string Nom;
	int NbrNotes;p
	double *TabNotes;

public : 

	Etudiant()
	{

	}

	Etudiant(int N)
	{
		NbrNotes = N;
		TabNotes = new double(NbrNotes);
	}

	~Etudiant()
	{
		delete[]TabNotes;
	}

	int getMatricule()
	{
		return Matricule;
	}
	void setMatricule(int mat)
	{
		Matricule = mat;
	}

	string getNom()
	{
		return Nom;
	}
	void setNom(string N)
	{
		Nom = N;
	}

	int getNbrNotes()
	{
		return NbrNotes;
	}
	void setNbrNotes(int Nbr)
	{
		NbrNotes = Nbr;
	}

	virtual void Saisir();
	virtual void Afficher();
	virtual double Moyenne();
	bool Comparer(Etudiant&, Etudiant&);
	
	
};

class EtudiantChercheur : public Etudiant
{
	int Matricule;
	string Nom;
	int NbrNminip;
	double *TabNminip;

public :

	EtudiantChercheur()
	{

	}

	EtudiantChercheur(int N)
	{
		NbrNminip = N;
		TabNminip = new double(NbrNminip);
	}

	int getMatricule()
	{
		return Matricule;
	}
	void setMatricule(int mat)
	{
		Matricule = mat;
	}

	string getNom()
	{
		return Nom;
	}
	void setNom(string N)
	{
		Nom = N;
	}

	int getNbrNotes()
	{
		return NbrNminip;
	}
	void setNbrNotes(int Nbr)
	{
		NbrNminip = Nbr;
	}

	void Saisir();
	void Afficher();
	double Moyenne();

};