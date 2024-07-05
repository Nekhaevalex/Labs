################################################################################
# Program: prepare_data.r
# Author:  @Nekhaevalex
# Purpose: Prepares data for Lab 1.1.4
# Input:   data.xlsx
# Output:  experimental.counts
################################################################################

# Loading dependencies
library(tidyverse)
library(sassy)
library(readxl)

# Enabling logging
log_open(
    "./Physics_Labs/1_sem/Lab114/rmarkdown/preparation.log",
    autolog = TRUE,
    show_notes = TRUE
)

sep("Setting up library")
libname(experimental, "./Physics_Labs/1_sem/Lab114/rmarkdown/data/experimental")
source_data <- "./Physics_Labs/1_sem/Lab114/data.xlsx"

sep("Preparing COUNT dataset")

df20 <-
    read_excel(
        source_data,
        sheet = "20 sec",
        col_names = FALSE
    ) |>
    pivot_longer(
        everything(),
        names_to = "time",
        values_to = "value"
    ) |>
    mutate(time = 20)

df40 <-
    read_excel(
        source_data,
        sheet = "40 sec",
        col_names = FALSE
    ) |>
    pivot_longer(
        everything(),
        names_to = "time",
        values_to = "value"
    ) |>
    mutate(time = 40)

experimental$counts <-
    bind_rows(df20, df40)

sep("Writing datasets")

lib_write(experimental)

log_close()