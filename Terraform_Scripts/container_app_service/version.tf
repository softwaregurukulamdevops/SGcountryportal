terraform {
  # Specify the minimum version of Terraform required
  required_version = ">= 1.1.0"  # You can adjust this to match the version you want to use

  required_providers {
    azurerm = {
      source  = "hashicorp/azurerm"
      version = "~> 3.0"  # Specify the required version of the Azure provider
    }
  }
}
