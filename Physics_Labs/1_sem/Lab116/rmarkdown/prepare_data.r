################################################################################
# Program: prepare_data.r
# Author:  @Nekhaevalex
# Purpose: Prepares data for Lab 1.1.6
# Input:   generator.csv
#          afc.csv
# Output:  experimental.generator
#          experimental.afc
################################################################################

# Loading dependencies
library(tidyverse)
library(sassy)
library(readxl)

# Enabling logging
log_open(
    "./Physics_Labs/1_sem/Lab116/rmarkdown/preparation.log",
    autolog = TRUE,
    show_notes = TRUE
)

sep("Setting up library")
libname(experimental, "./Physics_Labs/1_sem/Lab116/rmarkdown/data/experimental")

experimental$generator <-
    read_csv("./Physics_Labs/1_sem/Lab116/generator.csv")

experimental$afc <-
    read_csv("./Physics_Labs/1_sem/Lab116/afc.csv")

experimental$pfc <-
    read_csv("./Physics_Labs/1_sem/Lab116/pfc.csv")

sep("Writing datasets")

lib_write(experimental)

log_close()