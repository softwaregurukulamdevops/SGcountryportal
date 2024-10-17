provider "azurerm" {
  features {}
}

# Define the Resource Group
resource "azurerm_resource_group" "example" {
  name     = "rg-countryportal-resources"
  location = "South India"  # Replace with your desired location
}

# Define the Standard App Service Plan
resource "azurerm_app_service_plan" "standard_plan" {
  name                = "rg-countryportal-app-service-plan"
  location            = azurerm_resource_group.example.location
  resource_group_name = azurerm_resource_group.example.name
  kind                = "App"
  
  sku {
    tier = "Basic"
    size = "B1"  # Adjust size according to your needs
  }
}

# Define the Code-based App Service
resource "azurerm_app_service" "code_service" {
  name                = "rg-countryportal-code-app-service"
  location            = azurerm_resource_group.example.location
  resource_group_name = azurerm_resource_group.example.name
  app_service_plan_id = azurerm_app_service_plan.standard_plan.id

  app_settings = {
    "SOME_SETTING" = "value"
  }
}

# Output the URL
output "code_app_service_default_hostname" {
  value = azurerm_app_service.code_service.default_site_hostname
}
