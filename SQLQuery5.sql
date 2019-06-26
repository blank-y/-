select Role.RoleName,Role.FounctionID
from employee,Role,Menu
where employee.RoleName=Role.RoleName and Role.FounctionID=Menu.ID