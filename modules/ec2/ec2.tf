
variable "ec2name" {
  type=string

}

 

resource "aws_instance" "ec2"{
ami="ami-0caa91d6b7bee0ed0"
instance_type="t2.micro"
tags = {
  Name =var.ec2name
}
}

