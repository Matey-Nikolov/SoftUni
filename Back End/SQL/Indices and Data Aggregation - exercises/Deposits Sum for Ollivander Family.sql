SELECT DepositGroup,SUM(DepositAmount) FROM WizzardDeposits
GROUP BY DepositGroup, MagicWandCreator
HAVING MagicWandCreator = 'Ollivander family'