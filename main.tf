provider "aws" {
    region = "us-west-2"
  
}

 module "ec2module" {
    source="./modules/ec2"
    ec2name = "MyServer"
  
}
 