# Tutorial

<h2>Basic Command</h2>
<ul>
  <li>For Migration
    <ul>
      <li>Enable Migration --> Enable-Migration -ContextTypeName ApplicationDbContext -MigrationsDirectory Tutorial.DAL.ApplicationDbMigration.Configuration</li>
      <li>Add Migration --> Add-Migration -ConfigurationTypeName Tutorial.DAL.ApplicationDbMigration.Configuration "InitialMigration"</li>
      <li>Update Migration --> Update-Database -ConfigurationTypeName Tutorial.DAL.ApplicationDbMigration.Configuration</li>
      <li>Rollback all Migration --> Update-Database -ConfigurationTypeName Tutorial.DAL.ApplicationDbMigration.Configuration -TargetMigration:0</li>
    </ul>
  </li>
  <li>For Scaffolding
    <ul>
      <li>
        Create Controller --> Scaffold Controller {ModelName} -DbContextType ApplicationDb -ControllerName {ControllerName}
        <br/><small><i>ControllerName is optional parameter. If not specify, program will be generate controller name with modeal name + "Controller" </i></small>
      </li>
    </ul>
  </li>
</ul>
