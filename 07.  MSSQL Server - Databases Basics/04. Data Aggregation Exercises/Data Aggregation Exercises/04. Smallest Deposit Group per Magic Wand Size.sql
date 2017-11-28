SELECT DepositGroup FROM WizzardDeposits
GROUP BY DepositGroup
HAVING AVG(MagicWandSize) < (SELECT AVG(MagicWandSize) FROM WizzardDeposits)